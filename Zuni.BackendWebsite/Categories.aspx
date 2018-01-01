<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniBackend.master" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div>
       <h1> Category Addition/View </h1>
        <br />
    </div>
    <div>
        <table>
<tr>
    <td>
        Category Name:  
    </td>
    <td>
          <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
    </td>
</tr>
  
            <tr>
    <td>
        Category Description:  
    </td>
    <td>
          <asp:TextBox ID="txtdescription" runat="server"></asp:TextBox>
    </td>
</tr>
  <tr>
      <td>
          <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" />
      </td>
  </tr>
         </table>
   <br />
        <br />
       
        <br />
        <asp:GridView ID="GridView1" runat="server" Width="748px" 
            BackColor="White" BorderColor="#DEDFDE" 
                          BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" AutoGenerateColumns="False">
        <RowStyle BackColor="#F7F7DE" />
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Description" HeaderText="Description" />
            </Columns>
        <FooterStyle BackColor="#CCCC99" />
        <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
    </asp:GridView>

       
    </div>


</asp:Content>


