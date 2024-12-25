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

public partial class AddOutWarehouse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string date, id, name, number,inprice, total, notes, sale, person,getprice;
            date =DateTime.Now.ToString("yyyy-MM-dd");
            id = this.TextBox2.Text;
            name = this.TextBox3.Text;
            number = this.TextBox4.Text;
            inprice = this.TextBox5.Text;
            total = this.TextBox6.Text;
            notes = this.TextBox7.Text;
            sale = this.DropDownList1.Text;
            person = this.DropDownList2.Text;
            getprice = this.TextBox1.Text;

            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into OutWarehouse(ODate,Number,ProductName,Count,InPrice,Total,Notes,SupplyUnit,Person,GetPrice) values ('" + date + "','" + id + "','" + name + "','" + number + "','" + inprice + "','" + total + "','" + notes + "','" + sale + "','" + person + "','" + getprice + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('添加出库记录成功！');</script>");
            Server.Transfer("ManagerOutWarehouse.aspx");
        }
    }
    private bool IsNull()
    {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('出库编号不能为空！');</script>");
                return false;
            }
            else
            {
                if (this.TextBox3.Text == "")
                {
                    Response.Write("<script language='javascript'>alert('出库产品名不能为空！');</script>");
                    return false;
                }

                else
                {
                    if (this.TextBox5.Text == "")
                    {
                        Response.Write("<script language='javascript'>alert('产品出货价不能为空！');</script>");
                        return false;
                    }
                    else
                    {
                        if (this.TextBox6.Text == "")
                        {
                            Response.Write("<script language='javascript'>alert('出库产品总价不能为空！');</script>");
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
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("ManagerOutWarehouse.aspx");
    }
}

