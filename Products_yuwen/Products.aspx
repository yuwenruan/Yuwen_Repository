<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Products.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        <br />
    </p>
    <p>
        Customer:<asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <asp:Button ID="btnLogout" runat="server" OnClick="btnLogout_Click" Text="Logout" />
    <p>
        Total Spend:<asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
    </p>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID ="ObjectDataSource2" ShowFooter="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" >
        <Columns>
            <asp:BoundField DataField="ProdName" HeaderText="Product Name" SortExpression="ProdName" />
            <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
            <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
            <asp:BoundField DataField="TripStart" HeaderText="TripStart" SortExpression="TripStart" DataFormatString="{0:d}" />
            <asp:BoundField DataField="TripEnd" HeaderText="TripEnd" SortExpression="TripEnd" DataFormatString="{0:d}" />
            <asp:BoundField DataField="BasePrice" HeaderText="BasePrice" SortExpression="BasePrice" DataFormatString="{0:c}" />
            <asp:BoundField DataField="AgencyCommission" HeaderText="AgencyCommission" SortExpression="AgencyCommission" DataFormatString="{0:c}" />
        </Columns>
    </asp:GridView>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetBookingProductById" TypeName="BookingProductDB">
            <SelectParameters>
                <asp:SessionParameter Name="customerId" SessionField="CustomerId" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
    <p>
        Total in Packages: <asp:Label ID="lblPackage" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="PackageId" HeaderText="Package ID" SortExpression="PackageId" />
                <asp:BoundField DataField="PkgName" HeaderText="Package Name" SortExpression="PkgName" />
                <asp:BoundField DataField="PkgStartDate" HeaderText="Start Date" SortExpression="PkgStartDate" DataFormatString="{0:d}" />
                <asp:BoundField DataField="PkgEndDate" HeaderText="End Date" SortExpression="PkgEndDate" DataFormatString="{0:d}" />
                <asp:BoundField DataField="PkgDesc" HeaderText="Description" SortExpression="PkgDesc" />
                <asp:BoundField DataField="PkgBasePrice" HeaderText="Base Price" SortExpression="PkgBasePrice" DataFormatString="{0:c}" />
                <asp:BoundField DataField="PkgAgencyCommission" HeaderText="Agency Commission" SortExpression="PkgAgencyCommission" DataFormatString="{0:c}" />
            </Columns>
        </asp:GridView>
    </p>
    <p>
        <asp:ObjectDataSource ID="ObjectDataSource1" 
            runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetProductsByCustomerId" TypeName="PackageDB">
            <SelectParameters>
                <asp:SessionParameter Name="customerId" SessionField="CustomerId" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

