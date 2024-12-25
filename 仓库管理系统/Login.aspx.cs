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

public partial class Login : System.Web.UI.Page
{
    private readonly string ConnectionString = ConfigurationManager.AppSettings["ConnectionString"].ToString();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session["Admin"] = this.TextBox1.Text.Trim();
        }
			
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
			string str;
            str = "select Pwd from Users where UserName=@name";
			SqlConnection con=new SqlConnection(ConnectionString);
			SqlCommand cmd= new SqlCommand(str,con);
			cmd.Parameters.Add("@name",SqlDbType.VarChar,20);
			cmd.Parameters["@name"].Value=this.TextBox1.Text.Trim();
			con.Open();
			SqlDataReader dr=cmd.ExecuteReader();
			if (dr.Read())
			{
				
				string pwd=dr[0].ToString();

				dr.Close();
				if(pwd!=TextBox2.Text.Trim())
				{
					this.lab .Text="输入的密码不正确！";
				}
				else
				{
                    Session["Admin"] = this.TextBox1.Text.Trim();
                    Response.Redirect("ManagerFrame.aspx");
				}
				
			}
			else
			{
				this.lab .Text="抱歉,你没有权限操作!";
				con.Close();
			}

		}

    protected void Button2_Click(object sender, EventArgs e)
    {
        this.TextBox1.Text = "";
        this.TextBox2.Text = "";
    }
}