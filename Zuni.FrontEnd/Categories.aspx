<%@ Page Title="Category" Language="C#" MasterPageFile="~/ZuniFrontend.Master" AutoEventWireup="true" 
    CodeBehind="Categories.aspx.cs" Inherits="Zuni.FrontEnd.Categories" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  		<div class="dash-boxs">

                 <asp:Repeater ID="rptCategory" runat="server">
                     <ItemTemplate>
								<div class="dash-item">
								<a href="Product.aspx?pid=<%# Eval("CategoryId") %>" class="square">
                                    <div class="item-contant">
                                    <h5><%# Eval("Name") %></h5>
								    </div>
								</a>
				                </div>
                     </ItemTemplate>
                </asp:Repeater>
         
			</div>
</asp:Content>