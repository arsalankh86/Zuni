<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.Master" AutoEventWireup="true" CodeBehind="AddCustomer.aspx.cs" Inherits="Zuni.FrontEnd.AddCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    		<div class="card-header">
						<!-- <i class="fa fa-bars"></i> -->
						<h1>Customer information</h1>
					</div>
					<div class="card-body">
						<div class="card-form">
							<div class="input-field has-icon">
								<input type="text" id="name" name="name" placeholder="User id" runat="server">
								<i class="fa fa-user"></i>
							</div>
							<div class="input-field has-icon">
								<input type="email" id="email" name="email" placeholder="Email" runat="server">
								<i class="fa fa-envelope"></i>
							</div>
							<div class="input-field has-icon">
								<input type="text" id="phone" name="phone" placeholder="Phone" runat="server">
								<i class="fa fa-phone"></i>
							</div>
						</div>
					</div>


</asp:Content>
