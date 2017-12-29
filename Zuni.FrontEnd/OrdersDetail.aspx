<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.Master" AutoEventWireup="true" 
    CodeBehind="OrdersDetail.aspx.cs" Inherits="Zuni.FrontEnd.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    		<div class="app-card">
					<div class="card-header">
						<!-- <i class="fa fa-bars"></i> -->
						<h1>Order Products</h1>
					</div>
					<div class="card-body ">
						<div class=""><!--table-responsive-->
							<table class="table table-bordered table-striped ">
								<thead>
									<tr>
										<th class="text-center">
											S.No
										</th>
										<th>
											Products
										</th>
										<th class="text-center">
											Qty
										</th>
										<th class="text-center">
											Action
										</th>
									</tr>
								</thead>
								<tbody class="qty-control">
                                    <asp:Repeater ID="rptCart" runat="server" OnItemCommand="rptCart_ItemCommand">
        
        <ItemTemplate>
          <tr>
										<td  class="text-center">
											<%# Eval("SNO") %>
										</td>
										<td>
											<%# Eval("Name") %>
                                               <td class="price">$<%# Eval("ProductPrice")%></td>
										</td>
										<td  class="text-center">
											<%--<button class="btn btn-link min-btn"><i class="fa fa-minus-square"></i></button>--%>
											<input class="qty-input" type="number" value='<%# Eval("Quantity")%>'>
											<%--<button class="btn btn-link plus-btn"><i class="fa fa-plus-square"></i></button>--%>
										</td>
										<td  class="text-center">
											<asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Eval("ShoppingCartRecID") %>' CommandName="LinkRemove" >
                                                <button class="btn btn-link del-btn"><i class="fa fa-trash"></i></button>
                                                </asp:LinkButton>
                                            <asp:HiddenField ID="hdncartid" runat="server" Value='<%# Eval("ShoppingCartRecID") %>' />
										</td>
									</tr>
                                  </ItemTemplate>
                                  </asp:Repeater>
									
								</tbody>							
							</table>
						</div>
					</div>					
				</div>

</asp:Content>
