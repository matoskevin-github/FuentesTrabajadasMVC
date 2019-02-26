﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DemoASP.NetWCF.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>


</head>
<body>
    <form id="form1" runat="server">


        <asp:GridView ID="GridViewProduct" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="299px" Width="345px">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <br />
        <asp:Label ID="lblProductId" runat="server" Text="Product Id"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <br />
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
        <asp:Label ID="txtName" runat="server"></asp:Label>

        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price:"></asp:Label>
        <asp:Label ID="txtPrice" runat="server"></asp:Label>   

    </form>
</body>
</html>