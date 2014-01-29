<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="changePassword.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="border: 1px solid black">
        <tr>
            <td colspan="2"><b>Change Password</b> </td>
        </tr>
        <tr id="trCurrentPassword" runat="server">
            <td>Current Password </td>
            <td>:<asp:TextBox ID="txtCurrentPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCurrentPassword" runat="server" ControlToValidate="txtCurrentPassword" ErrorMessage="Current Password required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>New Password </td>
            <td>:<asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorNewPassword" runat="server" ControlToValidate="txtNewPassword" ErrorMessage="New Password required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Confirm New Password </td>
            <td>:<asp:TextBox ID="txtConfirmNewPassword" runat="server" TextMode="Password">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmNewPassword" runat="server" ControlToValidate="txtConfirmNewPassword" Display="Dynamic" ErrorMessage="Confirm New Password required" ForeColor="Red" Text="*"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidatorPassword" runat="server" ControlToCompare="txtNewPassword" ControlToValidate="txtConfirmNewPassword" Display="Dynamic" ErrorMessage="New Password and Confirm New Password must match" ForeColor="Red" Operator="Equal" Text="*" Type="String">
            </asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>&nbsp;<asp:Button ID="btnSave" runat="server" Text="Save" Width="70px" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblMessage" runat="server">
            </asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Login.aspx">Login</asp:HyperLink>
            </td>
        </tr>
    </table>
</asp:Content>

