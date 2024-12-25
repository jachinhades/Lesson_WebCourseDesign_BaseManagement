<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateOutWarehouse.aspx.cs" Inherits="UpdateOutWarehouse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head >
   <title></title>
<style type="text/css">
.STYLE1 {color: #FF0000;  font-size :small ;}
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
td{ line-height :33px;}
    .style3
    {
        font-size: medium;
        color :White ;
    }
    .style4
    {
        text-align: center;
    }
</style>

</head>

<body background="Image/4.jpg"><form id="form1" name="form1" method="post" runat="server" action="">
<div>
<table border="1" align="center" cellpadding="5" cellspacing="1" bgcolor="#eeeeee" style="width: 100%">
  
  <tr bgcolor="##CCCCFF">
    <td colspan="2" style="height: 10px"><div align="center">
        <strong><span class="style3">产品出库信息修改</span></strong>（<span class="STYLE1">带*号的信息必需填写</span>）</div></td>
  </tr>
 
  <tr>
      <td bgcolor="#ffffff" colspan="2" height="10">
          出&nbsp;&nbsp; 库&nbsp;&nbsp; 编&nbsp;&nbsp; 号：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><span class="STYLE1">*</span><span
            style="color: #666666">&nbsp;</span></td>
        
    </tr>
     <tr>
    <td  style="height: 10px" colspan="2">
        出库产品名称：<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><span class="style2"><span class="STYLE1">*</span> </span><span class="style2">
        </span></td>
    </tr>
  <tr>
   
            <td bgcolor="#FFFFFF" style="height: 10px;" colspan="2">
                出库产品数量：<asp:TextBox ID="TextBox4" runat="server" Width="127px"></asp:TextBox></td>
  </tr>
  <tr>
    <td  style="height: 10px;" colspan="2">
        出&nbsp;&nbsp; &nbsp;&nbsp; 货&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;价：<asp:TextBox 
            ID="TextBox5" runat="server" Width="127px"></asp:TextBox><span class="STYLE1"></span></td>
  </tr>
  <tr align="center">
      <td align="left" bgcolor="#ffffff" colspan="2" style="height: 10px">
          <span >出库产品总价：<asp:TextBox
                ID="TextBox6" runat="server"></asp:TextBox><span style="color: #ff0000"></span></span></td>
  </tr>
  <tr align="center">
      <td align="left" colspan="2" style="height: 10px">
          <span>收&nbsp;&nbsp; 到&nbsp;&nbsp; 货&nbsp; 款：<asp:TextBox
                ID="TextBox1" runat="server"></asp:TextBox><span style="color: #ff0000"></span></span></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2">
        收&nbsp;&nbsp; 货&nbsp;&nbsp; 单&nbsp; 位：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource3"
            DataTextField="Name" DataValueField="Name">
        </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:kc_dbConnectionString %>"
            SelectCommand="SELECT [Name] FROM [ReceivingUnit]"></asp:SqlDataSource>
        &nbsp;
    </td>
    </tr>
    <tr>
    <td style="height: 10px" colspan="2">
        经 &nbsp;&nbsp;&nbsp;&nbsp; 手 &nbsp;&nbsp;&nbsp; 人：<asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2"
            DataTextField="Name" DataValueField="Name">
        </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:kc_dbConnectionString %>"
            SelectCommand="SELECT [Name] FROM [Person]"></asp:SqlDataSource>
    </td>
    </tr>
    <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2">
        备 &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; 注：<asp:TextBox ID="TextBox7" runat="server" Width="127px"></asp:TextBox><span class="style2"><span class="STYLE1"></span></span></td>
    </tr>
  
  <tr align="center">
    <td colspan="2"  style="height: 10px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" 
            Width="74px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" 
            Width="74px" /></td>
  </tr>
   <tr align="left">
    <td colspan="2" bgcolor="#FFFFFF" style="height: 10px" class="style4">
        <span > 提示：请输入有效的数字&nbsp;</span></td>
  </tr></table></div>


</form></body>
</html>
