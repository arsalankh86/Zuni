<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
    
    <title>Zuni | Login</title>
    
    <!-- Jquery JS -->
    <script src="assets/jquery/jquery-2.2.0.min.js" type="text/javascript"></script>
    
    <!-- Bootstrape CSS and JS -->
    <link href="assets/bootstrap/css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    
    <!-- Font Awesome CSS -->
    <link href="assets/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">   
    
    <!-- Zuni CSS -->
    <link href="css/zuni-style.css" rel="stylesheet" type="text/css">
    <link href="css/zuni-responsive.css" rel="stylesheet" type="text/css">
    
    <!-- Zuni JS -->
	<script src="js/zuni-script.js"></script>
	
	
	
</head>
<body  class="app-bg">
    <form id="form1" runat="server">
    <!--	Zuni App Login Start	-->

	<div class="login-screen">
		
		<img class="logo" src="imgs/round-logo.png">

		<div class="login-form">
			<div class="input-field has-icon">
				<input type="email" id="email" placeholder="User id" runat="server">
				<i class="fa fa-user"></i>
			</div>
			<div class="input-field has-icon">
				<input type="password" id="password" placeholder="Password" runat="server">
				<i class="fa fa-unlock-alt"></i>
			</div>
			<div class="input-field">
                 <asp:Button ID="Button1" runat="server" Text="LOGIN" OnClick="Button1_Click" />
			</div>
		</div>

	</div>
    
<!--	Zuni App Login End	-->

    </form>
</body>
</html>
