﻿using System;
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

public partial class AddReceivingUnit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (IsNull())
        {
            string number, name, address, tel, people;
            number = this.TextBox1.Text;
            name = this.TextBox2.Text;
            address = this.TextBox3.Text;
            tel = this.TextBox4.Text;
            people = this.TextBox5.Text;
            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["ConnectionString"]);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ReceivingUnit(Number,Name,Address,tel,person) values ('" + number + "','" + name + "','" + address + "','" + tel + "','" + people + "')", con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
            Response.Write("<script language='javascript'>alert('收货单位添加成功！');</script>");
            Server.Transfer("ManagerReceivingUnit.aspx");
        }
    }
    private bool IsNull()
    {
        if (this.TextBox1.Text == "")
        {
            Response.Write("<script language='javascript'>alert('编号不能为空！');</script>");
            return false;
        }
        else
        {
            if (this.TextBox2.Text == "")
            {
                Response.Write("<script language='javascript'>alert('名称不能为空！');</script>");
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
        Server.Transfer("ManagerReceivingUnit.aspx");
    }
}


