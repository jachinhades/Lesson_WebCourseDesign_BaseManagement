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

public partial class ManagerSupplyUnits : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bind();
        }
    }
    private void Bind()
    {
        /*
        string s = "select * from SupplyUnit order by GId desc";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(s, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();
        */
        string sqlcoon = "Data Source=DESKTOP-5EMUFJI;Initial Catalog=BaseManagement;Integrated Security=True";
        string sql = "select * from SupplyUnit order by GId desc";
        using (SqlConnection con = new SqlConnection(sqlcoon))//SqlConnection连接，用using释放连接
        {
            using (SqlCommand com = new SqlCommand(sql, con))//SqlCommand连接，用using释放连接
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    //打开连接
                    con.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();
                    GridView1.DataSource = ds.Tables[0].DefaultView;
                    GridView1.DataBind();
                    //关闭连接
                    con.Close();
                    //释放连接
                    // con.Dispose();

                }
            }
        }
    }
    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        /*
        string s = "delete from SupplyUnit where GId='" + this.GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        SqlCommand cmd = new SqlCommand(s, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Bind();
        */
        string sqlcoon = "Data Source=DESKTOP-5EMUFJI;Initial Catalog=BaseManagement;Integrated Security=True";
        string sql = "delete from SupplyUnit where GId='" + this.GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        using (SqlConnection con = new SqlConnection(sqlcoon))//SqlConnection连接，用using释放连接
        {
            using (SqlCommand com = new SqlCommand(sql, con))//SqlCommand连接，用using释放连接
            {
                con.Open();
                int resert = Convert.ToInt32(com.ExecuteNonQuery());
                con.Close();
                Bind();
            }
        }
        Response.Write("<script language='javascript'>alert('经手人信息删除成功！');</script>");
    }
}