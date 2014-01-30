<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Welcome.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Welcome
    <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <asp:HyperLink CSSClass="HyperLink" runat="server" href="changePassword.aspx">Change Password</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink CssClass="HyperLink" runat="server" href="Customer.aspx">Customer Information</asp:HyperLink>
    <br />
    <br />
    <asp:HyperLink CssClass="HyperLink" runat="server" href="Products.aspx">Products</asp:HyperLink>
    <br />
</asp:Content>

