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

public partial class AddWarehouse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string name, number, notes;
            name = this.TextBox1.Text;
            number = this.TextBox2.Text;
            notes = this.TextBox5.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Warehouse(Name,Number,Notes) values ('" + name + "','" + number + "','" + notes + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('添加成功！');</script>");
            Server.Transfer("ManagerWarehouse.aspx");
        }
    }
    private bool IsNull()
    {
        if (this.TextBox1.Text == "")
        {
            Response.Write("<script language='javascript'>alert('仓库名不能为空！');</script>");
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
