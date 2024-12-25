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

public partial class UpdateInventory : System.Web.UI.Page
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
        str = "select * from Result where HId='" + ID + "'";
        SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            this.TextBox1.Text = dr["Name"].ToString();
            this.TextBox2.Text = dr["Number"].ToString();
            this.TextBox3.Text = dr["Unit"].ToString();
            this.TextBox4.Text = dr["Result"].ToString();

        }
        dr.Close();
        con.Close();
    }
      private bool IsNull()
    {
        if (this.TextBox1.Text == "")
        {
            Response.Write("<script language='javascript'>alert('产品名称不能为空！');</script>");
            return false;
        }
        else
        {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('产品编号不能为空！');</script>");
                return false;
            }
            else
            {
                if (this.TextBox3.Text == "")
                {
                    Response.Write("<script language='javascript'>alert('产品单位不能为空！');</script>");
                    return false;
                }
                else
                {
                    if (this.TextBox4.Text == "")
                    {
                        Response.Write("<script language='javascript'>alert('盘存数量不能为空！');</script>");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
     protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string id = Request.QueryString["ID"];
            string name, number, unit, count, place;
            name = this.TextBox1.Text;
            number = this.TextBox2.Text;
            unit = this.TextBox3.Text;
            count = this.TextBox4.Text;
            place = this.DropDownList1.Text;
            SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Result set Name='" + name + "',Number='" + number + "',Unit='" + unit + "',Warehouse='" + place + "',Result='" + count + "' where HId='" + id + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('盘存信息更新成功！');</script>");
            Server.Transfer("ManagerInventory.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("ManagerInventory.aspx");
    }
}
   
