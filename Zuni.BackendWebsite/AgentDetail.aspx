<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniBackend.master" AutoEventWireup="true" CodeFile="AgentDetail.aspx.cs" Inherits="AgentDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

    <div class="admin-card">
						<div class="head">
							<h2>Agent</h2>
							<i class="head-icon fa fa-user"></i>					
							<button class="head-btn btn btn-link"><i class="fa fa-minus"></i></button>
							
						</div>
         <div class="card-list">
    		<div class="app-card">
					<div class="card-header">
						<!-- <i class="fa fa-bars"></i> -->
						<h1>Agent Addition </h1>
					</div>
					<div class="card-body">
						<div class="card-form">
							<div class="form-control">
								<input type="text" id="name" name="name" placeholder="Name" runat="server"  required="required">

								<i class="fa fa-user"></i>
							</div>
							<div class="form-control">
								<input type="email" id="email" name="email" placeholder="Email" runat="server" required="required">
								<i class="fa fa-envelope"></i>
							</div>
							<div class="form-control">
								<input type="text" id="password" name="password" placeholder="Password" runat="server" required="required">
								<i class="fa fa-phone"></i>
							</div>
						</div>
                        <asp:Label ID="lblerror" runat="server" Text="" ForeColor="Red"></asp:Label>
					</div>
					<div class="card-footer">
						<div class="vertical-stack">
                            <asp:Button ID="btnCreateAgent" runat="server" Text="Create Agent" 
                                OnClick="btnCreateAgent_Click" />
						</div>
					</div>
				</div>

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


</asp:Content>

