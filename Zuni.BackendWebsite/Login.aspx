<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
    
    <title>Zuni Admin</title>
    
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
	
	<!-- Zuni Fav Icons -->
	<link rel="icon" href="imgs/fav-icons/fav-icon-32x32.png" sizes="32x32">
	<link rel="icon" href="imgs/fav-icons/fav-icon-192x192.png" sizes="192x192">
	<link rel="apple-touch-icon-precomposed" href="imgs/fav-icons/fav-icon-180x180.png">
	
</head>

<body class="zuni-bg">
        <form id="form1" runat="server">
<!--	Zuni Login Start	-->

	<div class="login-panel">

		<div class="brand-pan">
			<img src="imgs/zuni-round-logo.png">
		</div>

		<div class="form-pan">
				<h1>Welcome to Zuni admin panel</h1>

				<label for="email">Email</label>
				<input type="email" id="email" placeholder="example@domain.com" runat="server" required="required">

				<label for="password">Password</label>
				<input type="password" id="password" placeholder="Password" runat="server" required="required">

				<%--<div class="forget-pass"><a href="http://marketing.vitalsoft.co.uk/AdminHTML/forget.html">Forget your password?</a></div>--%>

				<%--<button type="submit" form="login-form">Login</button>--%>

            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" 
                style="background-color:#ec008c; font-family:Roboto-Medium; font-size:18px; color:white;" />
		</div>
        

	</div>
    
<!--	Zuni Login End	-->
            </form>
</body>
