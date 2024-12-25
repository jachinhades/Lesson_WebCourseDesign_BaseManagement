<%@ Page Language="C#" AutoEventWireup="true" Inherits="Login" UICulture="Auto" Codebehind="Login.aspx.cs" %>
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
            text-align: center;
        }
        .style2
        {
            font-size: xx-large;
            font-weight: bold;
            text-align: left;
            
        }
        td { border :solid 1px #d4d4d4;
             
              line-height :35px;}
</style>
</head>
<body background="Image/4.jpg">
    <p>
&nbsp;
    </p>
    <form id="form1"   runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
      
        <table   align="center" style="width: 390px;   border-collapse :collapse  ">
         <tr style="text-align: center">
                <td style="height: 78px; " colspan="2" class="style2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 用户登录</td>
            </tr>
        
            <tr>
                <td style="height: 18px; width: 181px; border-right :0px">
                      &nbsp;&nbsp;&nbsp;    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;用户名：</td>
                <td style="height: 18px; width: 422px; border-left :0px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="138px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 131px; height: 28px;border-right :0px">
                      &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;   密&nbsp;&nbsp;&nbsp;&nbsp;码：</td>
                <td style="width: 422px; height: 28px;border-left :0px">
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="136px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="height: 46px; " class="style1" colspan="2">
                <br />
                    &nbsp;&nbsp;&nbsp;   &nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" 
                        Width="74px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                    <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click" 
                        Width="74px" />
                    <asp:Label ID="lab" runat="server" ForeColor="Red" Width="128px"></asp:Label>
                    <br />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
