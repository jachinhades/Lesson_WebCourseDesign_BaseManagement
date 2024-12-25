<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManagerSupplyUnits.aspx.cs" Inherits="ManagerSupplyUnits" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
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
    }
</style>
</head>

<body background="Image/4.jpg">
 <form id="form2" name="form2" method="post" runat="server" action=""> 
<table width="100%" border="1" align="center" cellpadding="5" cellspacing="1" bgcolor="#CCCCCC">
     <tr>
    <td height="10" bgcolor="blue" style="width: 59%; color: #FFFFFF;">
        <div align="center" class="style1"><strong>管理供货单位</strong></div></td>
  </tr>
</table>
<table width="100%" border="1" align="center" cellpadding="5" cellspacing="0">
    <tr>
      <td style="width: 100%; height: 10px;" align="center"><asp:GridView ID="GridView1" 
              runat="server" AutoGenerateColumns="False" 
      OnPageIndexChanging="GridView1_PageIndexChanging1" 
              OnRowDeleting="GridView1_RowDeleting"  Width="100%" CellPadding="4"   
              PageSize="8" HorizontalAlign="Left" AllowPaging="True" DataKeyNames ="GId" 
              ForeColor="#333333" GridLines="None">
              <Columns>
                  <asp:BoundField DataField="GId" Visible="False" />
                  <asp:BoundField DataField="Number" HeaderText="供货单位编号" />
                  <asp:BoundField DataField="Name" HeaderText="供货单位名称" />
                  <asp:BoundField DataField="Address" HeaderText="供货单位地址" />
                  <asp:BoundField DataField="tel" HeaderText="供货单位电话" />
                  <asp:BoundField DataField="person" HeaderText="供货单位联系人" />
                  <asp:HyperLinkField DataNavigateUrlFields="GId" DataNavigateUrlFormatString="UpdateBuyUnit.aspx?ID={0}"
                        HeaderText="修改" Text="修改" />
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
</form>

</body>
</html>


