<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <table style="border: 1px solid black">
        <tr>
            <td colspan="2"><b>User Registration</b> </td>
        </tr>
        <tr>
            <td>User Name </td>
            <td>:<asp:TextBox ID="txtUserName" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorusername" runat="server" ControlToValidate="txtUserName" ErrorMessage="User Name required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Password </td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 4px" TextMode="Password">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Confirm Password </td>
            <td>:<asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmPassword" runat="server" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="Confirm Password required" ForeColor="Red" Text="*"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="Password and Confirm Password must match" ForeColor="Red" Operator="Equal" Text="*" Type="String">
            </asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td>Email </td>
            <td>:<asp:TextBox ID="txtEmail" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Email required" ForeColor="Red" Text="*"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Invalid Email" ForeColor="Red" Text="*" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
            </asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td>First Name </td>
            <td>:<asp:TextBox ID="txtFirstname" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Last Name </td>
            <td>:<asp:TextBox ID="txtLastName" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName" runat="server" ControlToValidate="txtLastName" ErrorMessage="User Name required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Address </td>
            <td>:<asp:TextBox ID="txtAddress" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage=" Address required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>City </td>
            <td>:<asp:TextBox ID="txtCity" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCity" runat="server" ControlToValidate="txtCity" ErrorMessage="City required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Province </td>
            <td>:<asp:TextBox ID="txtProvince" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorProvince" runat="server" ControlToValidate="txtProvince" ErrorMessage="Province required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Country </td>
            <td>:<asp:TextBox ID="txtCountry" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCountry" runat="server" ControlToValidate="txtUserName" ErrorMessage="Country required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Home Phone </td>
            <td>:<asp:TextBox ID="txtHomePhone" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorHomePhone" runat="server" ControlToValidate="txtHomePhone" ErrorMessage="Home Phone required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Business Phone </td>
            <td>:<asp:TextBox ID="TxtBusPhone" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorTxtBusPhone" runat="server" ControlToValidate="txtBusPhone" ErrorMessage="Business Phone required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Postal Code </td>
            <td>:<asp:TextBox ID="txtPostal" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPostal" runat="server" ControlToValidate="txtPostal" ErrorMessage="Postal Code required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnRegister" runat="server" onclick="btnRegister_Click" Text="Register" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server" ForeColor="Red">
            </asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
        </tr>
    </table>
    <br />
</asp:Content>

