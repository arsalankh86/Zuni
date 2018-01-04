<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.master" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
    <div class="dash-boxs">

    <div class="card-list">
       
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
											Product
										</th>
                                        <th>
											Price
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
										</td>
              <td class="price">$<%# Eval("ProductPrice")%></td>
										<td  class="text-center">
											<%--<button class="btn btn-link min-btn"><i class="fa fa-minus-square"></i></button>--%>
											<input class="qty-input" type="number" value='<%# Eval("Quantity")%>'>
											<%--<button class="btn btn-link plus-btn"><i class="fa fa-plus-square"></i></button>--%>
										</td>
										<td  class="text-center">
										<asp:ImageButton ID="LinkButton1" CausesValidation="false" runat="server" 
                                             CommandArgument='<%# Eval("ShoppingCartRecID") %>' CommandName="LinkRemove"  ImageUrl="~/imgs/del.png" Width="50px" Height="50px"  >
                                               </asp:ImageButton>
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
        <div align="right"><a href="Categories.aspx"> <u>Go Back</u></a></div>
				<div class="app-card">
					<div class="card-header">
						<!-- <i class="fa fa-bars"></i> -->
						<h1>Customer information</h1>
					</div>

                    
                    <asp:Panel ID="pnlcustdetail" runat="server">
					<div class="card-body">
						<div class="card-form">
                            <div style="padding:5px;">
								 Customer: <asp:DropDownList ID="ddlCustomer" runat="server" OnSelectedIndexChanged="ddlCustomer_SelectedIndexChanged1" AutoPostBack="True"  
                                    ></asp:DropDownList>
							</div>
							<div class="input-field has-icon">
								<input type="text" id="name" name="name" placeholder="User id" runat="server" >
								<i class="fa fa-user"></i>
							</div>
							<div class="input-field has-icon">
								<input type="email" id="email" name="email" placeholder="Email" runat="server" >
								<i class="fa fa-envelope"></i>
							</div>
							<div class="input-field has-icon">
								<input type="text" id="phone" name="phone" placeholder="Phone" runat="server" >
								<i class="fa fa-phone"></i>
							</div>
						</div>
					</div>
                        </asp:Panel>
					<div class="card-footer">
						<!-- <div class="col-xs-6 horizontal-stack">
							<button>Save Order</button>
						</div>
						<div class="col-xs-6 horizontal-stack">
							<button>Save &amp; Confirm Order</button>
						</div> -->
						<div class="vertical-stack">
                            <asp:Button ID="btnOrder" runat="server" Text="Save Order" OnClick="btnOrder_Click"  style="width: 100%;    background-color: #f0047f;    border: none;    font-size: 18px;    color: #fff;    padding: 7px 10px;    border-radius: 20px;" />
							<%--<button></button>--%>
						</div>
						<div class="vertical-stack">
                            <asp:Button ID="btnConfirmOrder" runat="server" Text="Save &amp; Confirm Order" OnClick="btnConfirmOrder_Click"  style="width: 100%;    background-color: #f0047f;    border: none;    font-size: 18px;    color: #fff;    padding: 7px 10px;    border-radius: 20px;" />
							<%--<button></button>--%>
						</div>
					</div>
				</div>

			</div>

</div>
    <script type="text/javascript" >

        function check()
        {
            alert("check");

            var txtname = document.getElementById("name");
            var txtemail = document.getElementById("email");
            var txtphone = document.getElementById("phone");

            if (name.val() == "" || email.val() == "" || phone.val() == "")
                return false;
        }

    </script>
</asp:Content>

