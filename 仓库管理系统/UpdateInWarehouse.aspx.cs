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
public partial class UpdateInWarehouse : System.Web.UI.Page
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
        str = "select * from InWarehouse  where IId='" + ID + "'";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        SqlCommand cmd = new SqlCommand(str, con); 
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.Read())
        {

            this.TextBox2.Text = dr["Number"].ToString();
            this.TextBox3.Text = dr["ProductName"].ToString();
            this.TextBox4.Text = dr["Count"].ToString();
            this.TextBox5.Text = dr["InPrice"].ToString();
            this.TextBox6.Text = dr["Total"].ToString();
            this.TextBox7.Text = dr["Notes"].ToString();
        }
        dr.Close();
        con.Close();
    }
    private bool IsNull()
    {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('入库产品编号不能为空！');</script>");
                return false;
            }
            else
            {
                if (this.TextBox3.Text == "")
                {
                    Response.Write("<script language='javascript'>alert('入库产品名称不能为空！');</script>");
                    return false;
                }

                else
                {
                    if (this.TextBox5.Text == "")
                    {
                        Response.Write("<script language='javascript'>alert('入库产品进货价格不能为空！');</script>");
                        return false;
                    }
                    else
                    {
                        if (this.TextBox6.Text == "")
                        {
                            Response.Write("<script language='javascript'>alert('入库产品总价不能为空！');</script>");
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
            string date, number, name, count, inprice, total, notes, unit, person;
            date = DateTime.Now.ToString("yyyy-MM-dd");
            number = this.TextBox2.Text;//danhao
            name = this.TextBox3.Text;//mingcheng
            count = this.TextBox4.Text;//Count
            inprice = this.TextBox5.Text;//jinhuojia
            total = this.TextBox6.Text;//zonge
            notes = this.TextBox7.Text;//Notes
            unit = this.DropDownList1.Text;
            person = this.DropDownList2.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("update InWarehouse set IDate='" + date + "',Number='" + number + "',ProductName='" + name + "',Count='" + count + "',InPrice='" + inprice + "',Total='" + total + "',Notes='" + notes + "',SupplyUnit='" + unit + "',Person='" + person + "' where IId='" + id + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('入库产品信息更新成功！');</script>");
            Server.Transfer("ManagerInWarehouse.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("ManagerInWarehouse.aspx");
    }
}
