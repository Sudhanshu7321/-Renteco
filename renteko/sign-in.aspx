<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sign-in.aspx.cs" Inherits="sign_in" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMassage" runat="server" Text=""></asp:Label>
            <table>
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
                <tr>
                    <td>
                         <p>
                             Email Id:
                          </p>
                     </td>
                    <td>
                        <asp:TextBox ID="EmailId" runat="server" placeholder="Email" ></asp:TextBox>
                     </td>
                </tr>
                   <tr>
                    <td>
                         <p>
                             Password:
                          </p>
                     </td>
                    <td>
                        <asp:TextBox ID="Password" runat="server" placeholder="password" type="password" ></asp:TextBox>
                     </td>
                </tr>
                  <tr>
                    <td>
                     </td>
                    <td>
                        <asp:Button ID="SingIn" runat="server" Text="Sign In" OnClick="SingIn_Click" />
                     </td>
                </tr>
            </table>
        </div>
    </form>

</body>
</html>
