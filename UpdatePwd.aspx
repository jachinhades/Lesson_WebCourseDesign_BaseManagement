<%@ Page Language="C#" AutoEventWireup="true" Inherits="UpdatePwd" Codebehind="UpdatePwd.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head>
    <title></title>
        <style type="text/css">
.STYLE1 {color: #FF0000; font-size :small }
body,td,th {
	font-size: 12px;
                text-align: left;
            }
body {
	margin-left: 0px;
	margin-right: 0px;
	margin-bottom: 0px;
	margin-top: 0px;
}
            .style1
            {
                font-size: large;
                font-weight: bold;
                text-align: left;
            }
            .style2
            {
                font-size: xx-large;
                color :White ;
            }
            td{ line-height :29px}
        </style>
</head>
<body background="Image/4.jpg">
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table style="width: 470px" align="center">
            <tr>
                <td colspan="2" align="center" class="style1">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span 
                        class="style2">
                    用户密码修改</span><br />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="height: 21px; text-align :right ;  color :White ; font-size :small " >
                    请输入新密码：</td>
                <td style="height: 21px">
                    <asp:TextBox ID="TextBox1" runat="server" Width="150px"></asp:TextBox></td>
            </tr>
            <tr>
                <td style ="text-align :right;color :White ; font-size :small  ">
                    请再次输入：</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="150px"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1"
                        ControlToValidate="TextBox2" ErrorMessage="输入的密码不一致"></asp:CompareValidator></td>
            </tr>
            <tr>
                <td align="right" colspan="2"  height="54px">
                  
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  
                    <asp:Button ID="Button1" runat="server" Text="确定" OnClick="Button1_Click" 
                        Width="75px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="取消" OnClick="Button2_Click" 
                        Width="75px" /></td>
            </tr>
            
            
            
        </table>
    
    </div>
    </form>
</body>
</html>
