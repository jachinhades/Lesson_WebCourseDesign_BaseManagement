﻿<%@ Page Language="C#" AutoEventWireup="true" Inherits="AddOutWarehouse" Codebehind="AddOutWarehouse.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head >
   <title></title>
<style type="text/css">
  
.STYLE1 {color: #FF0000}
body,td,th {
	font-size: 12pt;
}
.style2 {color: #666666}
body {
	margin-left: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	margin-top: 0px;
}
    .style3
    {
        font-size: medium;
        color :White ;
    }
    .style4
    {
        text-align: center;
    }
    td{ line-height :30px;}
</style>
<script language="javascript" type="text/javascript">
</script>
</head>

<body background="Image/4.jpg" ><form id="form1" name="form1" method="post" runat="server" action="">
<div>
<table border="1" align="center" cellpadding="5" cellspacing="1" bgcolor="#eeeeee" style="width: 100%">
  
  <tr bgcolor="#a4a4a4">
    <td colspan="2" style="height: 10px"><div align="center">
        <strong><span class="style3">产品出库信息登记</span></strong>（<span class="STYLE1">带*号的信息必需填写</span>）</div></td>
  </tr>
  
  <tr>
      <td bgcolor="#ffffff" colspan="2" height="10">
          产品出库编号：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><span class="STYLE1">*</span></td>
        
    </tr>
     <tr>
    <td style="height: 10px" colspan="2">
        <span>出库产品名称</span>：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><span class="style2"><span class="STYLE1">*</span> </span><span class="style2">
        </span></td>
    </tr>
  <tr>
  
            <td style="height: 10px;" colspan="2">
                产&nbsp; 品&nbsp;&nbsp; 数&nbsp;&nbsp; 量：<asp:TextBox ID="TextBox4" runat="server" Width="94px"></asp:TextBox><span class="STYLE1">*</span></td>
  </tr>
  <tr>
    <td style="height: 10px;" colspan="2">
        出&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 货&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 价：<asp:TextBox ID="TextBox5" runat="server" Width="97px"></asp:TextBox><span class="STYLE1">*</span></td>
  </tr>
  <tr align="center">
      <td align="left" bgcolor="#ffffff" colspan="2" style="height: 10px">
          <span>产&nbsp;&nbsp; 品&nbsp;&nbsp; 总&nbsp; 价：<asp:TextBox
                ID="TextBox6" runat="server"></asp:TextBox><span class="STYLE1">*</span></span></td>
  </tr>
  <tr align="center">
      <td align="left" colspan="2" style="height: 10px">
          <span>收&nbsp; 到&nbsp; 货&nbsp;&nbsp; 款：<asp:TextBox
                ID="TextBox1" runat="server"></asp:TextBox><span class="STYLE1">*</span></span></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2">
        收&nbsp; 货&nbsp; 单&nbsp;&nbsp; 位：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3"
            DataTextField="Name" DataValueField="Name">
        </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:kc_dbConnectionString %>"
            SelectCommand="SELECT [Name] FROM [ReceivingUnit]"></asp:SqlDataSource>
        &nbsp;
    </td>
    </tr>
    <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2">
        经 &nbsp; 手 &nbsp; 人： <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2"
            DataTextField="Name" DataValueField="Name">
        </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:kc_dbConnectionString %>"
            SelectCommand="SELECT [Name] FROM [Person]"></asp:SqlDataSource>
    </td>
    </tr>
    <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2">
        备 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 注：<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><span class="style2"><span class="STYLE1"></span></span></td>
    </tr>
  
  <tr align="center">
    <td colspan="2" bgcolor="#FFFFFF" style="height: 10px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" 
            Width="73px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" 
            Width="73px" /></td>
  </tr>
   <tr align="left">
    <td colspan="2" bgcolor="#FFFFFF" style="height: 10px" class="style4">
        <span>提示：请输入有效的数字 </span></td>
  </tr></table></div>


</form></body>
</html>
