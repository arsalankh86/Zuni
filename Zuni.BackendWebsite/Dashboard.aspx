﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniBackend.master" AutoEventWireup="true" CodeFile="Dashboard.aspx.cs" Inherits="Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">


  <div class="contant-view">

			<div class="title">
				<h1>Hi User,</h1>
				<p>Checkout your latest project and their progress.</p>
				<hr>
			</div>

			<div class="row">
				<div class="col-md-12">
					<div class="admin-card">
						<div class="head">
							<h2>Heading</h2>
							<i class="head-icon fa fa-user"></i>					
							<button class="head-btn btn btn-link"><i class="fa fa-minus"></i></button>
							
						</div>
						<div class="body">
							<div class="row">
								<div class="col-sm-6 col-md-3">
									<div class="data-box box-color-01">
										<h3>
                                            <asp:Label ID="lblConfirmOrderCount" runat="server" Text="Label"></asp:Label>
										</h3>
										<p>Confirm Orders</p>
										<a href="OrderDetail.aspx">More Info <i class="fa fa-arrow-circle-right"></i></a>
										<br>
									</div>
								</div>
								<div class="col-sm-6 col-md-3">
									<div class="data-box box-color-02">
										<h3> <asp:Label ID="lblSaveOrderCount" runat="server" Text="Label"></asp:Label></h3>
										<p>Save Only Order</p>
										<br>
										<a href="OrderDetail.aspx">More Info <i class="fa fa-arrow-circle-right"></i></a>
									</div>
								</div>
								<div class="col-sm-6 col-md-3">
									<div class="data-box box-color-03">
										<h3> <asp:Label ID="lblRegisteredCustomerCount" runat="server" Text="Label"></asp:Label></h3>
										<p>Registered customers</p>
										<br>
										<a href="CustomerDetail.aspx">More Info <i class="fa fa-arrow-circle-right"></i></a>
									</div>
								</div>
								<div class="col-sm-6 col-md-3">
									<div class="data-box box-color-04">
										<h3> <asp:Label ID="lblAgentCount" runat="server" Text="Label"></asp:Label></h3>
										<p>Agent</p>
										<br>
										<a href="AgentDetail.aspx">More Info <i class="fa fa-arrow-circle-right"></i></a>
									</div>
								</div>
							</div>										
						</div>
						<!-- <div class="foot">
								<button type="button" class="btn btn-primary btn-sm">Primary</button>
								<button type="button" class="btn btn-success btn-sm">Success</button>
								<button type="button" class="btn btn-info btn-sm">Info</button>
						</div> -->
					</div>
				</div>
			</div>

			<div class="row">
				<div class="col-md-8">
					<div class="admin-card">
						<div class="head">
							<h2>Customer</h2>
							<i class="head-icon fa fa-user"></i>					
							<button class="head-btn btn btn-link"><i class="fa fa-minus"></i></button>
							
						</div>
						<div class="body">
							<div class="table-responsive">  
							<table class="table table-bordered table-striped">
								<thead>
								<tr>
									<th>Name</th>
									<th>Phone</th>
									<th>Email</th>
                                    <th>Agent</th>
								</tr>
								</thead>
                                <asp:Repeater ID="rptCustomer" runat="server">
                                     <ItemTemplate>
								<tbody>
								<tr>
									<td><%# Eval("FirstName") %> <%# Eval("LastName") %></td>
									<td><%# Eval("MobilePhone") %></td>
									<td><%# Eval("Email") %></td>
                                     <td><%# Eval("AgentID") %></td>
								</tr>
								</tbody>
                                         </ItemTemplate>
                                    
                                    </asp:Repeater>
							</table>
							</div>					
						</div>
						<%--<div class="foot">
								<button type="button" class="btn btn-primary btn-sm">Primary</button>
								<button type="button" class="btn btn-success btn-sm">Success</button>
								<button type="button" class="btn btn-info btn-sm">Info</button>
						</div>--%>
					</div>
				</div>
				<div class="col-md-4">
					<div class="admin-card">
						<div class="head">
							<h2>Agent</h2>
							<i class="head-icon fa fa-user"></i>					
							<button class="head-btn btn btn-link"><i class="fa fa-minus"></i></button>
							
						</div>
						<div class="body">
							<div class="table-responsive">  
							<table class="table table-bordered table-striped">
								<thead>
								<tr>
									<th>Name</th>
									<th>Username</th>
									<th>Password</th>
								</tr>
								</thead>
								 <asp:Repeater ID="rptAgent" runat="server">
                                     <ItemTemplate>
								<tbody>
								<tr>
									<td><%# Eval("Name") %></td>
									<td><%# Eval("Username") %></td>
									<td><%# Eval("Password") %></td>
								</tr>
								</tbody>
                                         </ItemTemplate>
                                
                                    </asp:Repeater>
							</table>
							</div>					
						</div>
						<%--<div class="foot">
								<button type="button" class="btn btn-primary btn-sm">Primary</button>
								<button type="button" class="btn btn-success btn-sm">Success</button>
								<button type="button" class="btn btn-info btn-sm">Info</button>
						</div>--%>
					</div>
				</div>
			</div>
			
			<div class="row">
				<div class="col-md-12">
					<div class="admin-card">
						<div class="head">
							<h2>Order</h2>
							<i class="head-icon fa fa-user"></i>					
							<button class="head-btn btn btn-link"><i class="fa fa-minus"></i></button>
							
						</div>
						<div class="body">
							<div class="table-responsive">  
							<table class="table table-bordered table-striped">
								<thead>
								<tr>
									<th>Order Code</th>
                                    <th>Customer</th>
									<th>Status</th>
                                    <th>Amount</th>
                                    <th>Agent</th>
								</tr>
								</thead>
								 <asp:Repeater ID="rptOrder" runat="server">
                                     <ItemTemplate>
								<tbody>
								<tr>
									<td><%# Eval("OrderNumber") %> </td>
									<td><%# Eval("CustomerFirstName") %> <%# Eval("CustomerLastName") %></td>
									<td><%# Eval("OrderStatus") %></td>
                                    <td><%# Eval("OrderTotalAmount") %></td>
                                     <td><%# Eval("AgentID") %> <br /><%# Eval("AgentName") %></td>
								</tr>
								</tbody>
                                         </ItemTemplate>
                                   
                                    </asp:Repeater>
							</table>
							</div>					
						</div>
						<%--<div class="foot">
								<button type="button" class="btn btn-primary btn-sm">Primary</button>
								<button type="button" class="btn btn-success btn-sm">Success</button>
								<button type="button" class="btn btn-info btn-sm">Info</button>
						</div>--%>
					</div>
				</div>				
			</div>
						
		</div>

		<div class="footer row">
			<div class="col-md-4">
				Powerd by: <a href="#">company name</a> 
			</div>
			<div class="col-md-4 text-center">
				Date and Time
			</div>
			<div class="col-md-4 text-right">
				Verson:0.01
			</div>
		</div>
</asp:Content>

