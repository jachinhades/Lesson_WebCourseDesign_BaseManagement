<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddPeople.aspx.cs" Inherits="AddPeople" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
   <title></title>
<style type="text/css">
.STYLE1 {color: #FF0000}
body,td,th {
	font-size: 9pt;
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

</head>

<body background="Image/4.jpg"><form id="form1" name="form1" method="post" runat="server" action="">
<div>
<table border="1" align="center" cellpadding="5" cellspacing="1" bgcolor="#eeeeee" style="width: 100%">
  
  <tr bgcolor="#a4a4a4">
    <td colspan="2" style="height: 10px"><div align="center">
        <strong><span class="style3">经手人添加</span></strong>（<span class="STYLE1">带*号的信息必需填写</span>）</div></td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2" >
        编&nbsp;&nbsp;&nbsp; 号：<span class="style2"><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><span class="STYLE1">*</span> </span><span class="style2">
        </span></td>
    </tr>
  <tr>
    <td  colspan="2" >
                姓&nbsp;&nbsp;&nbsp; 名：<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><span class="STYLE1">*</span><span
            style="color: #666666"> &nbsp; &nbsp;</span></td>
        
    </tr>
  
  <tr>
      <td bgcolor="#ffffff" colspan="2" style="height: 10px">
                    电&nbsp;&nbsp;&nbsp; 话：<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><span
            style="color: #666666"> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; </span>
      </td>
  </tr>
  <tr align="center">
    <td colspan="2"  style="height: 10px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="提交" 
            Width="75px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server"  Text="返回" OnClick="Button2_Click" 
            Width="75px" /></td>
  </tr>
   <tr align="left">
    <td colspan="2" bgcolor="#FFFFFF" style="height: 10px" class="style4">
        提示：请输入有效的数字&nbsp;</td>
  </tr></table></div>


</form></body>
</html>