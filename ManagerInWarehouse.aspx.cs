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

public partial class ManagerInWarehouse : System.Web.UI.Page
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
        string sqlcoon = "Data Source=DESKTOP-5EMUFJI;Initial Catalog=BaseManagement;Integrated Security=True";
        string sql = "select IId,IDate,Number,ProductName,Count,InPrice,Total,Notes,SupplyUnit,Person from InWarehouse order by IId desc";
        using (SqlConnection con = new SqlConnection(sqlcoon))//SqlConnection连接，用using释放连接
        {
            using (SqlCommand com = new SqlCommand(sql, con))//SqlCommand连接，用using释放连接
            {
                using(SqlDataAdapter da = new SqlDataAdapter(sql, con))
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
        /*string s = "select IId,IDate,Number,ProductName,Count,InPrice,Total,Notes,SupplyUnit,Person from InWarehouse order by IId desc";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(s, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();*/
    }
    protected void GridView1_PageIndexChanging1(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        Bind();
    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string str = "delete from InWarehouse where IId='" + this.GridView1.DataKeys[e.RowIndex].Value.ToString() + "'";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        SqlCommand cmd = new SqlCommand(str, con);
        cmd.ExecuteNonQuery();
        con.Close();
        Bind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        /*string s = "select IId,IDate,Number,ProductName,Count,InPrice,Total,Notes,SupplyUnit,Person from InWarehouse where SupplyUnit ='" + TextBox1.Text + "'";
        SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
        con.Open();
        SqlDataAdapter da = new SqlDataAdapter(s, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        con.Close();
        GridView1.DataSource = ds.Tables[0].DefaultView;
        GridView1.DataBind();*/
        string sqlcoon = "Data Source=DESKTOP-5EMUFJI;Initial Catalog=BaseManagement;Integrated Security=True";
        string sql = "select IId,IDate,Number,ProductName,Count,InPrice,Total,Notes,SupplyUnit,Person from InWarehouse where SupplyUnit ='" + TextBox1.Text + "'";
        using (SqlConnection con = new SqlConnection(sqlcoon))//SqlConnection连接，用using释放连接
        {
            using (SqlCommand com = new SqlCommand(sql, con))//SqlCommand连接，用using释放连接
            {
                using (SqlDataAdapter da = new SqlDataAdapter(sql, con))
                {
                    //打开连接
                    con.Open();
                    /*
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();
                    GridView1.DataSource = ds.Tables[0].DefaultView;
                    GridView1.DataBind();
                    */

                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    con.Close();
                    GridView1.DataSource = ds.Tables[0].DefaultView;
                    GridView1.DataBind();
                    //关闭连接
                    //con.Close();
                    //释放连接
                    // con.Dispose();

                }
            }
        }
    }
}
