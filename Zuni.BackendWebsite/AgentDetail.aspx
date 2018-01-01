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

