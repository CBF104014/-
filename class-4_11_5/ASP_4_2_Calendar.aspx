<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASP_4_2_Calendar.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Calendar ID="Calendar1" runat="server">
            </asp:Calendar>
            <br />
            <asp:Button ID="Button1" runat="server" Text="<<" OnClick="Button1_Click" />
            &nbsp;<asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="1">禮拜一</asp:ListItem>
                <asp:ListItem Value="2">禮拜二</asp:ListItem>
                <asp:ListItem Value="3">禮拜三</asp:ListItem>
                <asp:ListItem Value="4">禮拜四</asp:ListItem>
                <asp:ListItem Value="5">禮拜五</asp:ListItem>
                <asp:ListItem Value="6">禮拜六</asp:ListItem>
                <asp:ListItem Value="0">禮拜日</asp:ListItem>
            </asp:DropDownList>
&nbsp;<asp:Button ID="Button2" runat="server" Text=">>" OnClick="Button2_Click" />
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
