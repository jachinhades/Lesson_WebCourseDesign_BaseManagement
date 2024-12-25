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
public partial class UpdateWarehouse : System.Web.UI.Page
{
    private string id;
    protected void Page_Load(object sender, EventArgs e)
    {
         if (!IsPostBack)
        {
            id = Request["ID"].ToString();
            Bind(id);
        }
    }
    private void Bind(string id)
    {
        string str;
        str = "select * from Warehouse where WId='" + id + "'";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            this.TextBox1.Text = dr["Name"].ToString();
            this.TextBox2.Text = dr["Number"].ToString();
            this.TextBox5.Text = dr["Notes"].ToString();  
        }
        dr.Close();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string bid = Request.QueryString["ID"];
            string name, number, notes;
            name = this.TextBox1.Text;
            number = this.TextBox2.Text;
            notes = this.TextBox5.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Warehouse set Name='" + name +"',Notes='" + notes + "',Number='" + number + "'  where WId='" + bid + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('出库信息修改成功！');</script>");
            Server.Transfer("ManagerWarehouse.aspx");
        }
    }
    private bool IsNull()
    {
        if (this.TextBox1.Text == "")
        {
            Response.Write("<script language='javascript'>alert('仓库名称不能为空！');</script>");
            return false;
        }
        else
        {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('仓库编号不能为空！');</script>");
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
        Server.Transfer("ManagerWarehouse.aspx");
    }
}
