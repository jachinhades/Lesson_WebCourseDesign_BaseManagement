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

public partial class AddInventory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(IsNull())
        {
            string name, number, Units, place, inventory;
            name = this.TextBox1.Text;
            number = this.TextBox2.Text;
            Units = this.TextBox3.Text;
            place = this.TextBox4.Text;
            inventory = this.DropDownList1.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Result(Name,Number,Unit,Warehouse,Result) values ('" + name + "','" + number + "','" + Units + "','" + inventory + "','" + place + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('添加盘存信息成功！');</script>");
            Server.Transfer("ManagerInventory.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("ManagerInventory.aspx");
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
}
