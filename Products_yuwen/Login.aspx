<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<script runat="server">

</script>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style1 {
            height: 40px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table style="border: 1px solid black">
        <tr>
            <td colspan="2"><b>Login</b> </td>
        </tr>
        <tr>
            <td>User Name </td>
            <td>:<asp:TextBox ID="txtUserName" runat="server">
            </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password </td>
            <td>:<asp:TextBox ID="txtPassword" runat="server" TextMode="Password">
            </asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:CheckBox ID="chkBoxRememberMe" runat="server" Font-size="Small" Text="Remember Me" />
            </td>
            <td class="auto-style1">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red">

            </asp:Label>
            </td>
        </tr>
    </table>
    <br />
<a href="Register.aspx">Click here to register</a> if you do not have a user name and password.
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

