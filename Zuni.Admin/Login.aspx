<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Zuni.Admin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    
    <meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
    
    <title>Zuni Admin</title>
    
    <!-- Jquery JS -->
    <script src="./Zuni Admin_files/jquery-2.2.0.min.js.download" type="text/javascript"></script>
    
    <!-- Bootstrape CSS and JS -->
    <link href="./Zuni Admin_files/bootstrap.min.css" rel="stylesheet" type="text/css">
    <script src="./Zuni Admin_files/bootstrap.min.js.download"></script>
    
    <!-- Font Awesome CSS -->
    <link href="./Zuni Admin_files/font-awesome.min.css" rel="stylesheet" type="text/css">   
    
    <!-- Zuni CSS -->
    <link href="./Zuni Admin_files/zuni-style.css" rel="stylesheet" type="text/css">
    <link href="./Zuni Admin_files/zuni-responsive.css" rel="stylesheet" type="text/css">
    
    <!-- Zuni JS -->
	<script src="./Zuni Admin_files/zuni-script.js.download"></script>
	
	<!-- Zuni Fav Icons -->
	<link rel="icon" href="http://marketing.vitalsoft.co.uk/AdminHTML/imgs/fav-icons/fav-icon-32x32.png" sizes="32x32">
	<link rel="icon" href="http://marketing.vitalsoft.co.uk/AdminHTML/imgs/fav-icons/fav-icon-192x192.png" sizes="192x192">
	<link rel="apple-touch-icon-precomposed" href="http://marketing.vitalsoft.co.uk/AdminHTML/imgs/fav-icons/fav-icon-180x180.png">
	

</head>
<body class="zuni-bg">
    <form id="form1" runat="server">
        
<!--	Zuni Login Start	-->

	<div class="login-panel">

		<div class="brand-pan">
			<img src="./Zuni Admin_files/zuni-round-logo.png">
		</div>

		<div class="form-pan">
				<h1>Welcome to Zuni admin panel</h1>

				<label for="email">Email</label>
				<input type="email" id="email" placeholder="example@domain.com" runat="server">

				<label for="password">Password</label>
				<input type="password" id="password" placeholder="Password" runat="server">

				<div class="forget-pass"><a href="http://marketing.vitalsoft.co.uk/AdminHTML/forget.html">Forget your password?</a></div>

				<%--<button type="submit" form="login-form">Login</button>--%>

            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" 
                style="background-color:#ec008c; font-family:Roboto-Medium; font-size:18px; color:white;" />
		</div>
        

	</div>
    
<!--	Zuni Login End	-->



    </form>
</body>
</html>
