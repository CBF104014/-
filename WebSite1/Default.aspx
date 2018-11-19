<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                    <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                    <asp:TemplateField HeaderText="132">
                        <ItemTemplate>
                            <%--<input id="Button1" name="BB" type="button" value="button" onclick="LinkButton1_Click" />--%>
                            <%--<asp:Button ID="Button1" name="BB" runat="server" CausesValidation="false" CommandName="Edit" OnClick="LinkButton1_Click" Text="按鈕" />--%>
                            <asp:Label ID="Label1" runat="server" value="aaa" Text='<%# Eval("Id") %>' ></asp:Label>
                            <asp:Button ID="LinkButton1" runat="server" CausesValidation="false" CommandName='<%# Eval("Id") %>' OnClick="LinkButton1_Click" Text="update"></asp:Button>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:dataConnectionString1 %>" SelectCommand="SELECT * FROM [login]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
