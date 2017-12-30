<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.master" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
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

