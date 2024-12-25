<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UpdateProductInfo.aspx.cs" Inherits="UpdateProductInfo" %>

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
    td{ line-height :32px}
</style>

</head>

<body background="Image/4.jpg"><form id="form1" name="form1" method="post" runat="server" action="">
<div>
<table border="1" align="center" cellpadding="5" cellspacing="1" bgcolor="#eeeeee" style="width: 100%">
  
  <tr bgcolor="#a4a4a4">
    <td colspan="2" style="height: 10px"><div class="style4">
        <strong><span class="style3">&nbsp;修改产品信息</span></strong>（<span class="STYLE1">带*号的信息必需填写</span>）</div></td>
  </tr>
  <tr>
      <td bgcolor="#ffffff" colspan="2" height="10">
          编&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;号：<asp:TextBox ID="TextBox2" 
              runat="server" Width="140px"></asp:TextBox><span class="STYLE1">*</span></td>
        
    </tr>
  <tr>
    <td bgcolor="" style="height: 10px" colspan="2">
        名&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;称：<asp:TextBox ID="TextBox1" runat="server" Width="140px"></asp:TextBox><span class="STYLE1">*</span>
        </td>
    </tr>
  
     <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2">
        <span > 单 &nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 位</span>：<asp:TextBox 
            ID="TextBox3" runat="server" Width="140px"></asp:TextBox><span class="style2"><span class="STYLE1">*</span> </span><span class="style2">
        </span></td>
    </tr>
  <tr>
  <td bgcolor="#FFFFFF" style="height: 10px;" colspan="2"> 
        存放仓库：<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" Width="140px"
            DataTextField="Name" DataValueField="Name">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:kc_dbConnectionString %>"
            SelectCommand="SELECT [Name] FROM [Warehouse]"></asp:SqlDataSource>
    </td>
  </tr>
  <tr align="center">
      <td align="left" colspan="2" style="height: 10px">
          <span >出库单价：<asp:TextBox
                ID="TextBox6" runat="server" Width="140px"></asp:TextBox><span style="color: #ff0000">*</span>
            <span class="style2"></span></span>
      </td>
  </tr>
  <tr>
    <td bgcolor="#FFFFFF" style="height: 10px;" colspan="2">
        入库单价：<asp:TextBox ID="TextBox5" runat="server" Width="140px"></asp:TextBox><span class="STYLE1">*</span></td>
  </tr>
    <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2">
        库存上限：<asp:TextBox ID="TextBox9" runat="server" Width="140px"></asp:TextBox><span class="style2"><span class="STYLE1">*</span> </span><s </span><span class="style2">
        </span></td>
    </tr>
  
    <td bgcolor="" style="height: 10px" colspan="2">
        库存下限：<asp:TextBox ID="TextBox8" runat="server" Width="140px"></asp:TextBox><span
            style="color: #ff0000">*</span>&nbsp;</td>
    </tr>
  
  <tr>
    <td bgcolor="#FFFFFF" style="height: 10px" colspan="2">
        原始库存：<asp:TextBox ID="TextBox7" runat="server" Width="140px"></asp:TextBox><span class="STYLE1">*</span> 
        </span></td>
    </tr>
  <tr align="center">
    <td colspan="2"  style="height: 10px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="更新" 
            Width="74px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click" 
            Width="74px" /></td>
  </tr>
   <tr align="left">
    <td colspan="2" bgcolor="#FFFFFF" style="height: 10px" align ="center" >
        提示：请输入有效的数字</td>
  </tr></table></div>


</form></body>
</html>
