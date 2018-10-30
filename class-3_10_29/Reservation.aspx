<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reservation.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            訂房日期：<asp:TextBox ID="TextBox1" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:ImageButton ID="ImageButton1" runat="server" Height="25px" ImageUrl="~/calendar.png" OnClick="ImageButton1_Click" Width="25px" />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False"></asp:Calendar>
            <br />
            退房日期：<asp:TextBox ID="TextBox2" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:ImageButton ID="ImageButton2" runat="server" Height="25px" ImageUrl="~/calendar.png" OnClick="ImageButton2_Click" Width="25px" />
            <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" Visible="False"></asp:Calendar>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="訂房" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
