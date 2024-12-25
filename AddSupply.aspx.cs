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

public partial class AddSupply : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string number, name, address,tel,person;
            number = this.TextBox1.Text;
            name = this.TextBox2.Text;
            address = this.TextBox3.Text;
            tel = this.TextBox4.Text;
            person = this.TextBox5.Text;
            /*
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into SupplyUnit(Number,Name,Address,tel,person) values ('" + number + "','" + name + "','" + address + "','" + tel + "','" + person + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('供货单位记录添加成功！');</script>");
            Server.Transfer("ManagerSupplyUnits.aspx");
            */
            string sqlcoon = "Data Source=DESKTOP-5EMUFJI;Initial Catalog=BaseManagement;Integrated Security=True";
            string sql = "insert into SupplyUnit(Number,Name,Address,tel,person) values (@Number, @Name, @Address, @tel, @person)";
            SqlParameter[] par = {
                new SqlParameter("@Number",number),
                new SqlParameter("@Name",name),
                new SqlParameter("@Address",address),
                new SqlParameter("@tel",tel),
                new SqlParameter("@person",person)
                };
            using (SqlConnection con = new SqlConnection(sqlcoon))//SqlConnection连接，用using释放连接

            {
                using (SqlCommand com = new SqlCommand(sql, con))//SqlCommand连接，用using释放连接

                {
                    com.Parameters.AddRange(par);
                    //打开连接
                    con.Open();

                    int resert = Convert.ToInt32(com.ExecuteNonQuery());
                    //关闭连接
                    con.Close();
                    //释放连接
                    // con.Dispose();
                }
            }
            Response.Write("<script language='javascript'>alert('供货单位记录添加成功！');</script>");
            Server.Transfer("ManagerSupplyUnits.aspx");
        }
    }
    private bool IsNull()
    {
        if (this.TextBox1.Text == "")
        {
            Response.Write("<script language='javascript'>alert('供货单位编号不能为空！');</script>");
            return false;
        }
        else
        {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('供货单位名称不能为空！');</script>");
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
        Server.Transfer("ManagerSupplyUnits.aspx");
    }
}

