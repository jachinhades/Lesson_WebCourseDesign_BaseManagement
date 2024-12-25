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

public partial class UpdatePwd: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
            string pwd;
            pwd = this.TextBox2.Text;
            string rname = Session["Admin"].ToString();
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("update Users set Pwd='" + pwd + "' where userName='"+rname+"'", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('密码修改成功！');</script>");
            Server.Transfer("Login.aspx");
       
    }
      
    protected void Button2_Click(object sender, EventArgs e)
    {
        this.TextBox1.Text = "";
        this.TextBox2.Text = "";
    }
}
