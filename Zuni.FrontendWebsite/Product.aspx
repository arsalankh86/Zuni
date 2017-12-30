<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.master" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Product" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
       	<div class="product-list">
                     
                 <asp:Repeater ID="rptProduct" runat="server" OnItemCommand="rptProduct_ItemCommand">
                     <ItemTemplate>
                          <div class="product-item">
					<div class="product">
						<img src="<%# Eval("ImageFilenameOverride") %>">
						<h3><%# Eval("Name") %></h3>
						<h4>PKR: <%# Eval("Profitpriceinrupee") %></h4>
						 <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("ProductID") %>'
                                            CommandName="Add" class="button" Text="Add to Cart" />
					</div>					
				</div>
                     </ItemTemplate>
                </asp:Repeater>
         
			</div>
</asp:Content>

