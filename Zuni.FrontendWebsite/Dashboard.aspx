<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    	<div class="dash-boxs">
				<div class="dash-item">
					<a href="Categories.aspx" class="square">
						<div class="item-contant">
							<img src="imgs/categories-icon.png">
							<h5>Categories</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="Product.aspx" class="square">
						<div class="item-contant">
							<img src="imgs/products-icon.png">
							<h5>Products</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="AddCustomer.aspx" class="square">
						<div class="item-contant">
							<img src="imgs/add-customer-icon.png">
							<h5>Add Customer</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="OrderDetail.aspx" class="square">
						<div class="item-contant">
							<img src="imgs/order-details-icon.png">
							<h5>Order Details</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="CustomerDetail.aspx" class="square">
						<div class="item-contant">
							<img src="imgs/customer-details-icon.png">
							<h5>Customer Details</h5>
						</div>
					</a>
				</div>
				<div class="dash-item">
					<a href="http://marketing.vitalsoft.co.uk/AppHTML/dashboard.html#" class="square">
						<div class="item-contant">
							<img src="imgs/other-icon.png">
							<h5>Other</h5>
						</div>
					</a>
				</div>
			</div>
</asp:Content>

