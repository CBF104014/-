<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ASP_4_3_word.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server" defaultbutton="Button2">
        <div>
			<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
			<asp:Button ID="Button1" runat="server" Text="測驗去" OnClick="Button1_Click" />

			<br />
			<asp:Literal ID="Literal1" runat="server"></asp:Literal>
            <br />

			-------------------<br />
&nbsp;<br />
			<asp:Literal ID="Literal2" runat="server"></asp:Literal>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="OK" OnClick="Button2_Click" />
            <br />
            <asp:Literal ID="Literal3" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
