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

public partial class UpdateProductInfo : System.Web.UI.Page
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
    private void Bind(string ID)
    {
        string str;
        str = "select * from Product where HId='" + ID + "'";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand(str, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {
            this.TextBox1.Text = dr["ProductName"].ToString();
            this.TextBox2.Text = dr["Number"].ToString();
            this.TextBox3.Text = dr["Unit"].ToString();
            this.TextBox5.Text = dr["InPrice"].ToString();
            this.TextBox6.Text = dr["OutPrice"].ToString();
            this.TextBox7.Text = dr["Original"].ToString();
            this.TextBox8.Text = dr["LowLine"].ToString();
            this.TextBox9.Text = dr["UpLine"].ToString();
          
        }
        dr.Close();
        con.Close();
    }
    private bool IsNull()
    {
        if (this.TextBox1.Text == "")
        {
            Response.Write("<script language='javascript'>alert('产品编号不能为空！');</script>");
            return false;
        }
        else
        {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('产品名称不能为空！');</script>");
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
                            Response.Write("<script language='javascript'>alert('入库单价不能为空！');</script>");
                            return false;
                        }
                        else
                        {
                            if (this.TextBox6.Text == "")
                            {
                                Response.Write("<script language='javascript'>alert('出库单价不能为空！');</script>");
                                return false;
                            }
                            else
                            {
                                if (this.TextBox7.Text == "")
                                {
                                    Response.Write("<script language='javascript'>alert('原始库存不能为空！');</script>");
                                    return false;
                                }
                                else
                                {
                                    if (this.TextBox8.Text == "")
                                    {
                                        Response.Write("<script language='javascript'>alert('库存下限不能为空！');</script>");
                                        return false;
                                    }
                                    else
                                    {
                                        if (this.TextBox9.Text == "")
                                        {
                                            Response.Write("<script language='javascript'>alert('库存上限不能为空！');</script>");
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
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string id = Request.QueryString["ID"];
            string name, number, unit, place, inunit, outunit, origanal, low, up;
            name = this.TextBox1.Text;
            number = this.TextBox2.Text;
            unit = this.TextBox3.Text;
            place = this.DropDownList1.Text;
            inunit = this.TextBox5.Text;
            outunit = this.TextBox6.Text;
            origanal = this.TextBox7.Text;
            low = this.TextBox8.Text;
            up = this.TextBox9.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Product set ProductName='" + name + "',Number='" + number + "',Unit='" + unit + "',Warehouse='" + place + "',InPrice='" + inunit + "',OutPrice='" + outunit + "',Original='" + origanal + "',LowLine='" + low + "',UpLine='" + up + "' where HId='" + id + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('产品信息更新成功！');</script>");
            Server.Transfer("ManagerProducts.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("ManagerProducts.aspx");
    }
}
