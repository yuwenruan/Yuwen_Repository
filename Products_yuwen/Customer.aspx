<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Customer.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="border: 1px solid black">
        <tr>
            <td colspan="2"><b>Customer Information</b> </td>
        </tr>
        <tr>
            <td>Id </td>
            <td>:<asp:TextBox ID="txtId" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorId" runat="server" ControlToValidate="txtId" ErrorMessage="Id required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>First Name </td>
            <td>:<asp:TextBox ID="txtFirstName" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorfirstname" runat="server" ControlToValidate="txtFirstName" ErrorMessage="First Name required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Last Name </td>
            <td>:<asp:TextBox ID="txtLastName" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorlastname" runat="server" ControlToValidate="txtLastName" ErrorMessage="Last Name required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Address </td>
            <td>:<asp:TextBox ID="txtAddress" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>City </td>
            <td>:<asp:TextBox ID="txtCity" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCity" runat="server" ControlToValidate="txtCity" ErrorMessage="City name required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Province </td>
            <td>:<asp:TextBox ID="txtProvince" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorProvince" runat="server" ControlToValidate="txtProvince" ErrorMessage="Province name required" ForeColor="Red" Text="*">
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
            <td>Country </td>
            <td>:<asp:TextBox ID="txtCountry" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorCountry" runat="server" ControlToValidate="txtCountry" ErrorMessage="Country name required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Home Phone </td>
            <td>:<asp:TextBox ID="txtHomePhone" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorHomePhone" runat="server" ControlToValidate="txtHomePhone" ErrorMessage="HomePhone required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Bus Phone </td>
            <td>:<asp:TextBox ID="txtBusPhone" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorBusPhone" runat="server" ControlToValidate="txtBusPhone" ErrorMessage="BusPhone required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
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
            <td>Agent Id </td>
            <td>:<asp:TextBox ID="txtAgentId" runat="server">
            </asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAgentId" runat="server" ControlToValidate="txtAgentId" ErrorMessage="Agent Id required" ForeColor="Red" Text="*">
            </asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="73px" />
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
    <br />
    <br />
</asp:Content>

