<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.master" AutoEventWireup="true" CodeFile="OrderDetail.aspx.cs" Inherits="OrderDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="app-card">
					<div class="card-header">
						<!-- <i class="fa fa-bars"></i> -->
						<h1>Order Detail</h1>
					</div>
    <asp:Panel runat="server"  ID="pnlorderdetail" Visible="false">
    <div class="card-body ">
						<div class=""><!--table-responsive-->
							<table class="table table-bordered table-striped ">
								<thead>
									<tr>
										<th class="text-center">
											Order Number
										</th>
										<th class="text-center" >
											Product Name
										</th>
										<th class="text-center">
											Quantity
										</th>
                                        <th class="text-center">
											Amount
										</th>
									</tr>
								</thead>
								<tbody class="qty-control">
                                    <asp:Repeater ID="rptOrderdetail" runat="server" >
        
                                    <ItemTemplate>
                                      <tr>
                                          <td class="text-center">
											<%# Eval("OrderNumber") %>
										</td>
										<td class="text-center">
											<%# Eval("OrderedProductName") %> <br />
										</td>
										<td  class="text-center">
											<%# Eval("Quantity") %>
										</td>
                                         <td  class="text-center">
											<%# Eval("OrderedProductAmount") %>
										</td>
                                          
									</tr>
                                  </ItemTemplate>
                                  </asp:Repeater>
									
								</tbody>							
							</table>
						</div>
					</div>	

			</asp:Panel>
    <br />
    		<div class="card-body ">
						<div class=""><!--table-responsive-->
							<table class="table table-bordered table-striped ">
								<thead>
									<tr>
										<th class="text-center">
											Order Number
										</th>
										<th class="text-center" >
											Customer Detail
										</th>
										<th class="text-center">
											Order Status
										</th>
                                        <th class="text-center">
											Order Total Amount
										</th>
                                        	<th class="text-center">
											Ordered Date
										</th>
                                        	
									</tr>
								</thead>
								<tbody class="qty-control">
                                    <asp:Repeater ID="rptOrder" runat="server" >
        
                                    <ItemTemplate>
                                      <tr>
                                          <td class="text-center">
										<a href="OrderDetail.aspx?ordercode=<%# Eval("OrderNumber") %>">	<%# Eval("OrderNumber") %> </a>
										</td>
										<td class="text-center">
											<%# Eval("Email") %> <br />
                                            <%# Eval("CustomerFirstName") %> <%# Eval("CustomerLastName") %> <br />
                                            <%# Eval("Phone") %> 
										</td>
										<td  class="text-center">
											<%# Eval("OrderStatus") %>
										</td>
                                         <td  class="text-center">
											<%# Eval("OrderTotalAmount") %>
										</td>
                                          <td  class="text-center">
											<%# Eval("CreatedDate") %>
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



