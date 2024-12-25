<%@ Page Language="C#" AutoEventWireup="true" Inherits="Menu" Codebehind="Menu.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
	<HEAD>
		<title></title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		
			
			<style type="text/css">
                .style1
                {
                    font-weight: bold;
                }
                /* 未访问前的样式 */
A:link
{
	color: #606060;
	font-size: 13px;
	text-decoration: none;
}
/* 鼠标激活样式 */
A:visited
{
	color: #606060;
	font-size: 13px;
	text-decoration: none;
}
/* 鼠标悬停时的样式 */
A:hover
{
	color: #191970;
	
	font-size: 13px;
	text-decoration: none;
}
            </style>
		
		<body background="Image/4.jpg">
		<form>
			
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="158" align="center">
				<TR style="CURSOR: hand">
					<TD height="25" ><b>管理产品</b></TD>
	
				<TR>
					<TD>
						<DIV id="DIV1" style="WIDTH: 158px">
							
							<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
								</TR>
									<td align="center" height="20"><A href="ManagerProducts.aspx" target="mainframe">产品管理</A></td>
							</TABLE>
							<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="AddProductInfo .aspx" target="mainframe">产品添加</A></td>
								</TR>
							</TABLE>
						</DIV>
					</TD>
				</TR>
			</TABLE>
			
			<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="158" align="center">
				<TR style="CURSOR: hand">
					<TD  height="25"><SPAN style="font-weight: 700">管理入库</SPAN>
					</TD>
				</TR>
				<TR>
					<TD>
						<DIV id="DIV2" style="WIDTH: 158px">
							
							<TABLE id="Table4" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="ManagerInWarehouse.aspx" target="mainframe">管理产品入库</A></td>
								</TR>
								
							</TABLE>
							<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="140" align="center">
								
							</TABLE>
							<TABLE id="Table7" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="AddInWarehouse.aspx" target="mainframe">登记产品入库</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table14" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="InWarehouseStatistics.aspx" target="mainframe">年度入库统计</A></td>
								</TR>
							</TABLE>
						</DIV>
					</TD>
				</TR>
			</TABLE>	
			
			<TABLE id="Table10" cellSpacing="0" cellPadding="0" width="158" align="center">
				<TR style="CURSOR: hand">
					<TD  height="25"><SPAN class="style1">管理出库</SPAN>
					</TD>
				</TR>
				<TR>
					<TD>
						<DIV id="DIV3" style="WIDTH: 158px">
						<TABLE id="Table13" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="ManagerOutWarehouse.aspx" target="mainframe">
                                        管理产品出库</A></td>
								</TR>
							<TABLE id="Table11" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="AddOutWarehouse.aspx" target="mainframe">登记产品出库							
							</TABLE>
							<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="OutWarehouseStatistics.aspx" target="mainframe">年度出库统计</A></td>
								</TR>
							</TABLE>
							
						</DIV>
					</TD>
				</TR>
			</TABLE>	
			
			<TABLE id="Table16" cellSpacing="0" cellPadding="0" width="158" align="center">
				<TR style="CURSOR: hand">
					<TD 
						height="25"><SPAN class="style1">管理盘存</SPAN>
					</TD>
				</TR>
				<TR>
					<TD>
						<DIV id="DIV4" style="WIDTH: 158px">
						<TABLE id="Table18" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="ManagerInventory.aspx" target="mainframe">管理产品盘存</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table17" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="AddInventory.aspx" target="mainframe">盘存产品添加</A></td>
								</TR>
							</TABLE>
							
							
						</DIV>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table21" cellSpacing="0" cellPadding="0" width="158" align="center">
				<TR style="CURSOR: hand">
					<TD height="25"><b>系统管理
					</b>
					</TD>
				</TR>
				<TR>
					<TD>
						<DIV id="DIV6" style="WIDTH: 158px">
							
							<TABLE id="Table26" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="AddReceivingUnit.aspx" target="mainframe">添加收货单位</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table27" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="ManagerReceivingUnit.aspx" target="mainframe">管理收货单位</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table22" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="AddSupply.aspx" target="mainframe">添加供货单位</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table25" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="ManagerSupplyUnits.aspx" target="mainframe">管理供货单位</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table30" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="AddWarehouse.aspx" target="mainframe">添加仓库</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table31" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="ManagerWarehouse.aspx" target="mainframe">管理仓库</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table28" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="AddPeople.aspx" target="mainframe">添加经手人</A></td>
								</TR>
							</TABLE>
							<TABLE id="Table29" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" height="20"><A href="ManagerPeople.aspx" target="mainframe">管理经手人</A></td>
								</TR>
							</TABLE>
							
						</DIV>
					</TD>
				</TR>
			</TABLE>
			<TABLE id="Table12" cellSpacing="0" cellPadding="0" width="158" align="center">
				<TR style="CURSOR: hand">
					<TD  
					   height="25" class="style1">
                        管理用户</TD>
				</TR>
				<TR>
					<TD>
						<DIV style="WIDTH: 158px">
							<TABLE id="Table9" cellSpacing="0" cellPadding="0" width="140" align="center">
								<TR>
									<td align="center" style="height: 20px"><A href="UpdatePwd.aspx" target="mainframe">密码修改</A></td>
								</TR>
							</TABLE>
						</DIV>
					</TD>
				</TR>
			</TABLE>
			<table cellSpacing="0" cellPadding="0" width="158" align="center">
				
				<tr>
					<td height="25"><A href="Login.aspx" target="_top">
							<strong>注销</strong></A>
					</td>
				</tr>
			</table>						
			
		</form>
	</body>
</HTML>
