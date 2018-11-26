<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sign in Member</title>
    <link href="css/bootstrap.css" rel="stylesheet" />
    <link href="css/mine.css" rel="stylesheet" />
    <script src="js/JavaScript_1.js"></script>
    <script src="js/JavaScript_2.js"></script>
    <script src="js/JavaScript_3.js"></script>
</head>
<body class="bg-dark">
    <form id="form1" runat="server" class="form-inline">
        <div class="div_center">
            <table class="table table-dark">
                <tr>
                    <td colspan="3" style="text-align:center;">
                        <h3 class="text-white">Sign in</h3>
                    </td>
                </tr>
                <tr>                    
                    <td colspan="3">
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>                        
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" CssClass="text-white" runat="server" Text="User name:"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox1" CssClass="form-control mx-sm-3" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" CssClass="text-white" runat="server" Text="Password:"></asp:Label></td>
                    <td><asp:TextBox ID="TextBox2" TextMode="Password" CssClass="form-control mx-sm-3" runat="server"></asp:TextBox></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Button ID="Button1" CssClass="btn btn-outline-info" Width="100%" runat="server" Text="Sign in" OnClick="Button1_Click" />
                    </td>
                </tr>
            </table>                         
            <button id="open" type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal" style="display:none">Open</button>
        </div>

        <div class="modal fade" id="exampleModal" runat="server" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
          <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">驗證碼認證</h5>
                </div>
                <div class="modal-body">
                    <div class="input-group mb-3">
                      <input id="ver_text" type="text" runat="server" class="form-control" placeholder="驗證碼" aria-label="Recipient's username" aria-describedby="button-addon2" />
                      <div class="input-group-append">
                          <asp:Button ID="Button2" runat="server" CssClass="btn btn-outline-secondary" Text="驗證" OnClick="Button2_Click1" />
                          <asp:Button ID="Button3" runat="server"  CssClass="btn btn-outline-secondary" Text="重新傳送" OnClick="Button3_Click" />
                      </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                </div>
            </div>
          </div>
        </div>
    </form>
</body>
</html>
