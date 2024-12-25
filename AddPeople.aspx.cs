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

public partial class AddPeople : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string name, number, tel;
            name = this.TextBox1.Text;
            number = this.TextBox2.Text;
            tel = this.TextBox5.Text;
            string sqlcoon = "Data Source=DESKTOP-5EMUFJI;Initial Catalog=BaseManagement;Integrated Security=True";
            string sql = "insert into Person(Number, Name, tel) values(@Name, @Number, @tel)";
            SqlParameter[] par = {
                new SqlParameter("@Number",number),
                new SqlParameter("@Name",name),
                new SqlParameter("@tel",tel),
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
            Response.Write("<script language='javascript'>alert('经手人信息添加成功！');</script>");
            Server.Transfer("ManagerPeople.aspx");
            /*
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Person(Number,Name,tel) values ('" + name + "','" + number + "','" + tel + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('经手人信息添加成功！');</script>");
            Server.Transfer("ManagerPeople.aspx");
            */
        }
    }
    private bool IsNull()
    {
        if (this.TextBox1.Text == "")
        {
            Response.Write("<script language='javascript'>alert('姓名不能为空！');</script>");
            return false;
        }
        else
        {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('编号不能为空！');</script>");
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
        Server.Transfer("ManagerPeople.aspx");
    }
}
