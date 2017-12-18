<%@ Page Title="" Language="C#" MasterPageFile="~/Zuni.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Zuni.Admin.Dashboard1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<%--<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">


    <h1>Order Summary</h1>
       <asp:GridView ID="GridView1" runat="server" Width="748px" 
            BackColor="White" BorderColor="#DEDFDE" 
                          BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="True">
        <RowStyle BackColor="#F7F7DE" />
            <AlternatingRowStyle BackColor="White" />
         
        <FooterStyle BackColor="#CCCC99" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>

</asp:Content>
