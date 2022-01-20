<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="discussionform.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    Registration
</head>
<body>
    <form id="form1" runat="server">
        <div style="background-color:aqua">
            <table>
                <tr>
                    <td>  <asp:Label ID="Label1" runat="server" Text="Id"></asp:Label></td>
                     <td><asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td><asp:Label ID="Label2" runat="server" Text="Name"></asp:Label></td>
                     <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Emailid"></asp:Label></td>
                     <td>
            <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Mobile"></asp:Label></td>
                     <td> <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox></td>
                </tr>
                
                <tr>
                    <td></td>
                     <td> <asp:Button ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
                  <asp:Button ID="BtnBack" runat="server" Text="Back" OnClick="BtnBack_Click" /></td>
                </tr>
            </table>
          
            
                 
            <hr />
            <asp:Label Text="" ID="lblResult" runat="server" />
            <hr />
            <h2>Users Details</h2>
            <asp:GridView ID="gvUsersDetails" runat="server"></asp:GridView>

        </div>
    </form>
</body>
</html>
