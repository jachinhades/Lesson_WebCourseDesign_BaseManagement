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

public partial class UpdateOutWarehouse : System.Web.UI.Page
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
    private void Bind(string bid)
    {
        string str;
        str = "select * from OutWarehouse where OId='" + bid + "'";
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
            Response.Write("<script language='javascript'>alert('编号不能为空！');</script>");
            return false;
        }
        else
        {
            if (this.TextBox3.Text == "")
            {
                Response.Write("<script language='javascript'>alert('名称不能为空！');</script>");
                return false;
            }

            else
            {
                if (this.TextBox5.Text == "")
                {
                    Response.Write("<script language='javascript'>alert('出货价不能为空！');</script>");
                    return false;
                }
                else
                {
                    if (this.TextBox6.Text == "")
                    {
                        Response.Write("<script language='javascript'>alert('总价不能为空！');</script>");
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
            string date, number, name, count, inprice, total, notes, unit, person,getmoney;
            date = DateTime.Now.ToString("yyyy-MM-dd");
            number = this.TextBox2.Text;
            name = this.TextBox3.Text;
            count = this.TextBox4.Text;
            inprice = this.TextBox5.Text;
            total = this.TextBox6.Text;
            notes = this.TextBox7.Text;
            unit = this.DropDownList1.Text;
            person = this.DropDownList2.Text;
            getmoney = this.TextBox1.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("update OutWarehouse set ODate='" + date + "',Number='" + number + "',ProductName='" + name + "',Count='" + count + "',InPrice='" + inprice + "',Total='" + total + "',Notes='" + notes + "',SupplyUnit='" + unit + "',Person='" + person + "',GetPrice='" + getmoney + "' where OId='" + id + "'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('出库信息更新成功！');</script>");
            Server.Transfer("ManagerOutWarehouse.aspx");
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("ManagerOutWarehouse.aspx");
    }
}
