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

public partial class AddProductInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
           string number, name, product, place,danwei,Outdanwei,orignal,lowline,upline;
            number = this.TextBox1.Text;
            name = this.TextBox2.Text;
            product = this.TextBox3.Text;
            place = this.DropDownList1.Text;
            danwei = this.TextBox5.Text;
            Outdanwei = this.TextBox6.Text;
            orignal = this.TextBox7.Text;
            lowline = this.TextBox8.Text;
            upline = this.TextBox9.Text;

            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Product(ProductName,Number,Unit,Warehouse,InPrice,OutPrice,Original,LowLine,UpLine) values ('" + number + "','" + name + "','" + product + "','" + place + "','" + danwei + "','" + Outdanwei + "','" + orignal + "','" + lowline + "','" + upline + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('产品信息添加成功！');</script>");
            Server.Transfer("ManagerProducts.aspx");
        }
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
                        if (this.TextBox5.Text == "")
                        {
                            Response.Write("<script language='javascript'>alert('产品入库单价不能为空！');</script>");
                            return false;
                        }
                        else
                        {
                            if (this.TextBox6.Text == "")
                            {
                                Response.Write("<script language='javascript'>alert('产品出库单价不能为空！');</script>");
                                return false;
                            }
                            else
                            {
                                if (this.TextBox7.Text == "")
                                {
                                    Response.Write("<script language='javascript'>alert('产品原始库存不能为空！');</script>");
                                    return false;
                                }
                                else
                                {
                                    if (this.TextBox8.Text == "")
                                    {
                                        Response.Write("<script language='javascript'>alert('产品库存下限不能为空！');</script>");
                                        return false;
                                    }
                                    else
                                    {
                                        if (this.TextBox9.Text == "")
                                        {
                                            Response.Write("<script language='javascript'>alert('产品库存上限不能为空！');</script>");
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
            }
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("manage.aspx");
    }
}
