<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .table_1 {
            width:40%;
            border:1px solid;
        }
        th, td {
            padding: 8px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
        .img_1 {
            height:100px;
            width:100px;
        }
        .btn_1 {
            background-color: white; 
            color: black; 
            border: 2px solid #f44336;
            padding: 2px 5px;
            font-size: 16px;
            cursor: pointer;
        }
    </style>
    <script type="text/javascript">
        function btn_click(id) {
            document.getElementById('Submit1').value = id;
            document.getElementById('Submit1').click();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server" method="post" action="Product_detail.aspx">
    <div>
        <table class="table_1">
                       
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </table>
    </div>        
        <input id="Submit1" name="pro_id" style="display:none" type="submit" value="" />
    </form>
</body>
</html>
