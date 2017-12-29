<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/ZuniFrontend.Master" AutoEventWireup="true" 
    CodeBehind="Dashboard.aspx.cs" Inherits="Zuni.FrontEnd.Dashboard" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  		<div class="dash-boxs">
				<div class="dash-item">
					<a href="Categories.aspx" class="square">
						<div class="item-contant">
							<img src="./Zuni _ Dashboard_files/categories-icon.png">
							<h5>Categories</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="Product.aspx" class="square">
						<div class="item-contant">
							<img src="./Zuni _ Dashboard_files/products-icon.png">
							<h5>Products</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="AddCustomer.aspx" class="square">
						<div class="item-contant">
							<img src="./Zuni _ Dashboard_files/add-customer-icon.png">
							<h5>Add Customer</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="OrdersDetail.aspx" class="square">
						<div class="item-contant">
							<img src="./Zuni _ Dashboard_files/order-details-icon.png">
							<h5>Order Details</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="CustomerDetail.aspx" class="square">
						<div class="item-contant">
							<img src="./Zuni _ Dashboard_files/customer-details-icon.png">
							<h5>Customer Details</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="http://marketing.vitalsoft.co.uk/AppHTML/dashboard.html#" class="square">
						<div class="item-contant">
							<img src="./Zuni _ Dashboard_files/other-icon.png">
							<h5>Other</h5>
						</div>
					</a>
				</div>
			</div>
</asp:Content>
