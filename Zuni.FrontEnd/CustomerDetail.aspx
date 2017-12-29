<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.Master" AutoEventWireup="true" CodeBehind="CustomerDetail.aspx.cs" Inherits="Zuni.FrontEnd.CustomerDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="card-list">

				<div class="app-card">
					<div class="card-header">
						<!-- <i class="fa fa-bars"></i> -->
						<h1>Customer Detail</h1>
					</div>
					<div class="card-body ">
						<div class=""><!--table-responsive-->
							<table class="table table-bordered table-striped ">
								<thead>
									<tr>
										<th class="text-center">
											Name
										</th>
										<th class="text-center" >
											Phone
										</th>
										<th class="text-center">
											Email
										</th>
									</tr>
								</thead>
								<tbody class="qty-control">
                                    <asp:Repeater ID="rptCustomer" runat="server" >
        
                                    <ItemTemplate>
                                      <tr>
										<td class="text-center">
											<%# Eval("FirstName") %> <%# Eval("LastName") %>
										</td>
										<td  class="text-center">
											<%# Eval("MobilePhone") %>
										</td>
                                         <td  class="text-center">
											<%# Eval("Email") %>
										</td>
									</tr>
                                  </ItemTemplate>
                                  </asp:Repeater>
									
								</tbody>							
							</table>
						</div>
					</div>					
				</div>
          </div>

</asp:Content>
