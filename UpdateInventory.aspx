<%@ Page Language="C#" AutoEventWireup="true" Inherits="UpdateInventory" Codebehind="UpdateInventory.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head >
   <title></title>
<style type="text/css">

.STYLE1 {color: #FF0000; font-size :small ;}
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
    td{ line-height :33px;}

</style>

</head>

<body background="Image/4.jpg"><form id="form1" name="form1" method="post" runat="server" action="">
<div>
<table border="1" align="center" cellpadding="5" cellspacing="1" bgcolor="#eeeeee" style="width: 100%">
  
  <tr bgcolor="#a4a4a4">
    <td colspan="2" style="height: 10px"><div align="center">
        <strong><span class="style3">盘存信息修改</span></strong>（<span class="STYLE1">带*号的信息必需填写</span>）</div></td>
  </tr>
  <tr>
    <td  bgcolor="#FFFFFF"colspan="2">
        产品编号：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><span class="STYLE1">*</span><span
            > &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; </span></td>
        
    </tr>
  <tr>
    <td  style="height: 10px" colspan="2">
        产品名称：<span class="style2"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><span class="STYLE1">*</span> </span><span class="style2">
        </span></td>
    </tr>
  
     <tr>
    <td bgcolor="#FFFFFF" style="height: 10px;" colspan="2">
        <span >产品单位</span>：<asp:TextBox ID="TextBox3" runat="server" Width="126px"></asp:TextBox><span class="STYLE1">*</span><span
            style="color: #666666">&nbsp;</span></td>
  </tr>
  
  <tr>
    <td style="height: 10px;" colspan="2">
        存放仓库：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1"
            DataTextField="Name" DataValueField="Name">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kc_dbConnectionString %>"
            SelectCommand="SELECT [Name] FROM [Warehouse]"></asp:SqlDataSource>
    </td>
  </tr>
  <tr align="center">
    <td align="left" bgcolor="#FFFFFF" style="height: 10px;" colspan="2">
        盘存数量：<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><span class="STYLE1">*</span>&nbsp;</td>
  </tr>
  
  <tr align="center">
    <td colspan="2" style="height: 10px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" 
            Width="74px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click"  Width ="74px"/></td>
  </tr>
   <tr align="left">
    <td colspan="2" bgcolor="#FFFFFF" style="height: 10px" class="style4">
       提示：请输入有效的数！&nbsp;</td>
  </tr></table></div>


</form></body>
</html>

