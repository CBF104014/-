<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .div_1{
            width:400px;
            height:400px;
            background-color:black;
            transition:all;
            transition-duration:3s;
        }
        .div_1:hover{
            background-color:white;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="div_1">
            <asp:Button ID="Button1" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
