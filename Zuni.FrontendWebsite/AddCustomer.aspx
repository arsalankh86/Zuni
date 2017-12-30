<%@ Page Title="" Language="C#" MasterPageFile="~/ZuniFrontend.master" AutoEventWireup="true" CodeFile="AddCustomer.aspx.cs" Inherits="AddCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
           <script type="text/javascript">
        function validateForm() {
            var name = document.getElementById("name");
            var email = document.getElementById("email");
            var phone = document.getElementById("phone");

            if (name == "") {
                alert("Name must be filled out");
                return false;
            }
            if (email == "") {
                alert("Email must be filled out");
                return false;
            }
            if (phone == "") {
                alert("Phone must be filled out");
                return false;
            }

        }

        function validateEmail() {
            var email = document.getElementById("email").value;
            var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
            return re.test(email.toLowerCase());
        }

    </script>
     <div class="card-list">
    		<div class="app-card">
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
								<input type="email" id="email" name="email" placeholder="Email" runat="server" onformchange="validateEmail()">
								<i class="fa fa-envelope"></i>
							</div>
							<div class="input-field has-icon">
								<input type="text" id="phone" name="phone" placeholder="Phone" runat="server">
								<i class="fa fa-phone"></i>
							</div>
						</div>
                        <asp:Label ID="lblerror" runat="server" Text="" ForeColor="Red"></asp:Label>
					</div>
					<div class="card-footer">
						<!-- <div class="col-xs-6 horizontal-stack">
							<button>Save Order</button>
						</div>
						<div class="col-xs-6 horizontal-stack">
							<button>Save &amp; Confirm Order</button>
						</div> -->
						<div class="vertical-stack">
                            <asp:Button ID="btnOrder" runat="server" Text="Create Customer" OnClick="btnOrder_Click" OnClientClick="validateForm()" />
							<%--<button></button>--%>
						</div>
					</div>
				</div>

        </div>
</asp:Content>

