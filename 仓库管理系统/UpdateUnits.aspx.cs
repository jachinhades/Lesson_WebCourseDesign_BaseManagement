using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Linq;

public partial class UpdateUnits : System.Web.UI.Page
{
    private string bid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            bid = Request["ID"].ToString();
            Bind(bid);
        }
    }
    private void Bind(string ID)
    {
        string str;
        str = "select * from ReceivingUnit where RId='" + ID + "'";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            this.TextBox1.Text = dr["Number"].ToString();
            this.TextBox2.Text = dr["Name"].ToString();
            this.TextBox3.Text = dr["Address"].ToString();
            this.TextBox4.Text = dr["tel"].ToString();
            this.TextBox5.Text = dr["person"].ToString();
        }
        dr.Close();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string id = Request.QueryString["ID"];
            string number, name, address, tel, person;
            number = this.TextBox1.Text;
            name = this.TextBox2.Text;
            address = this.TextBox3.Text;
            tel = this.TextBox4.Text;
            person = this.TextBox5.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("update ReceivingUnit set Number='" + number + "',Address='" + address + "',Name='" + name + "',person='" + person + "',tel='" + tel + "' where RId='" + id + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('收货单位修改成功！');</script>");
            Server.Transfer("ManagerReceivingUnit.aspx");
        }
    }
    private bool IsNull()
    {
        if (this.TextBox1.Text == "")
        {
            Response.Write("<script language='javascript'>alert('收货单位编号不能为空！');</script>");
            return false;
        }
        else
        {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('收货单位名称不能为空！');</script>");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("ManagerReceivingUnit.aspx");
    }
}

