<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManagerOutWarehouse.aspx.cs" Inherits="ManagerOutWarehouse" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head >
   <title></title>

<style type="text/css">
.STYLE1 {color: #FF0000}
body,td,th {
	font-size: 12pt;
}
body {
	margin-left: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	margin-top: 0px;
}
    .style1
    {
        font-size: medium;
        color: #FFFFFF;
    }
    #form2
    {
        text-align: center;
    }
    .style2
    {
        text-align: center;
    }
</style>
</head>

<body background="Image/4.jpg">
 <form id="form2" name="form1" method="post" runat="server" action=""> 
<table width="100%" border="1" align="center" cellpadding="5" cellspacing="1" bgcolor="#CCCCCC">
     <tr>
    <td height="10" bgcolor="blue" style="width: 59%"><div align="center" 
            class="style1"><strong>产品出库管理</strong></div></td>
  </tr>
</table>
<table width="100%" border="1" align="center" cellpadding="5" cellspacing="0">
    <tr>
      <td style="width: 100%; height: 10px;" align="center"><asp:GridView ID="GridView1" 
              runat="server" AutoGenerateColumns="False" 
      OnPageIndexChanging="GridView1_PageIndexChanging1" 
              OnRowDeleting="GridView1_RowDeleting"  Width="100%" CellPadding="4"   
              PageSize="8" HorizontalAlign="Left" AllowPaging="True" DataKeyNames="Oid" 
              ForeColor="#333333" GridLines="None">
              <Columns>
                  <asp:BoundField DataField="ODate" HeaderText="产品出库时间" />
                  <asp:BoundField DataField="Number" HeaderText="出库编号" />
                  <asp:BoundField DataField="ProductName" HeaderText="产品名称" />
                  <asp:BoundField DataField="Count" HeaderText="产品数量" />
                  <asp:BoundField DataField="InPrice" HeaderText="产品价格" />
                  <asp:BoundField DataField="Total" HeaderText="产品总价" />
                  <asp:BoundField DataField="GetPrice" HeaderText="收到产品货款" />
                  <asp:BoundField DataField="SupplyUnit" HeaderText="收货单位" />
                  <asp:BoundField DataField="Person" HeaderText="经手人" />
                  <asp:BoundField DataField="OId" Visible="False" />
                  <asp:HyperLinkField DataNavigateUrlFields="OId" DataNavigateUrlFormatString="UpdateOutWarehouse.aspx?ID={0}"
                        HeaderText="修改" Text="修改" Visible="True"/>
                  <asp:TemplateField HeaderText="删除">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete"
                                Text="删除"　onClientClick="return confirm('确定要删除吗?')" ></asp:LinkButton>
                        </ItemTemplate>
                  </asp:TemplateField>
              </Columns>
          <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
          <RowStyle ForeColor="#333333" BackColor="#FFFBD6" />
          <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
          <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
          <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" Height ="29" />
              <AlternatingRowStyle BackColor="White" />
          </asp:GridView>
      </td>
          
    </tr>
 
</table>
<table border="1" align="center" cellpadding="3" cellspacing="1" style="width: 100%">

    <tr align="left" >
        <td bgcolor="#ffffff" colspan="5" 
            style="width: 80%; height: 21px;" class="style2">
            请输入收货单位的名称： <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp; <asp:Button ID="Button2"
                runat="server" Text="产品出货查询" OnClick="Button2_Click" />
            </td>
    </tr>
      
</table>
</form>

</body>
</html>



