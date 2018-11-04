<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASP_4_1_Operand.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>請選擇</asp:ListItem>
                <asp:ListItem>+</asp:ListItem>
                <asp:ListItem>-</asp:ListItem>
                <asp:ListItem>*</asp:ListItem>
                <asp:ListItem>/</asp:ListItem>
            </asp:DropDownList>&nbsp;<asp:Literal ID="Literal2" runat="server"></asp:Literal>
        &nbsp;=
            <asp:Literal ID="Literal3" runat="server"></asp:Literal>
            <br />
            <asp:Literal ID="Literal4" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
