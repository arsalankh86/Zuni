<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniBackend.master" AutoEventWireup="true" CodeFile="ProductDetail.aspx.cs" Inherits="ProductDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


    <div>
    <table>
    <tr>
    <td>Category:</td>
    <td><asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList> </td>
     </tr>
    <tr>
    <td>Name:</td>
    <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox> </td>
    </tr>
 <%--   <tr>
    <td>SEName:</td>
    <td><asp:TextBox ID="txtSEName" runat="server"></asp:TextBox> </td>
    </tr>--%>

    <tr>
    <td>Description:</td>
    <td><asp:TextBox ID="txtDescription" runat="server"></asp:TextBox> </td>
    </tr>
   <tr>
    <td>Summary:</td>
    <td><asp:TextBox ID="txtSummary" runat="server"></asp:TextBox> </td>
    </tr>
     <tr>
    <td>Cost in Rupee:</td>
    <td><asp:TextBox ID="txtCostinrupee" runat="server"></asp:TextBox> </td>
    </tr>
    <%-- <tr>
    <td>Cost in Dollar:</td>
    <td><asp:TextBox ID="txtCostindollar" runat="server" 
            ></asp:TextBox> </td>
    </tr>
    --%>
     <tr>
    <td>Profit Price in Rupee:</td>
    <td><asp:TextBox ID="txtProfitpriceinrupee" runat="server" 
           ></asp:TextBox> </td>
    </tr>
    <%-- <tr>
    <td>Profit Price in Dollar:</td>
    <td><asp:TextBox ID="txtProfitpriceindollar" runat="server" 
            ></asp:TextBox> </td>
    </tr>--%>
   <%--  <tr>
    <td>Profit:</td>
    <td><asp:TextBox ID="txtprofit" runat="server" 
            ></asp:TextBox> </td>
    </tr>
     <tr>
    <td>StichedPrice:</td>
    <td><asp:TextBox ID="txtStichedPrice" runat="server"></asp:TextBox> </td>
    </tr>--%>
     <tr>
    <td>Image:</td>
    <td>
        <asp:FileUpload ID="imageFile" runat="server" /><asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
         </td>
    </tr>
   <%-- <tr>
    <td>Type:</td>
    <td>
    <asp:DropDownList ID="ddlType" runat="server">
     <asp:ListItem Value="Stiched"> Stiched  </asp:ListItem>
     <asp:ListItem Value="Unstiched"> Unstiched  </asp:ListItem>

        </asp:DropDownList>
         </td>
    </tr>      --%>
    </table>

        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" />

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
                <asp:BoundField HeaderText="Image Path" DataField="ImageFilenameOverride" />
                       <asp:BoundField HeaderText="Cost in Rupee" DataField="Costinrupee" />
                       <asp:BoundField HeaderText="Profit Price in Rupee" DataField="Profitpriceinrupee" />
                      <asp:BoundField HeaderText="Category Name" DataField="CatName" />
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