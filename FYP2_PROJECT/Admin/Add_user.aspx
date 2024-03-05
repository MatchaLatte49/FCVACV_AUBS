<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_user.aspx.cs" Inherits="FYP2_PROJECT.Add_user" %>

<!DOCTYPE html>
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.0.8/css/all.css">



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <%--Bootstrap--%>
   


    <title></title>

</head>

<body>
    
<form id="form1" runat="server">
<div class="container">

<br/>  
<br/>  
<br/>  
<div class="row justify-content-center">
<div class="col-md-6">
<div class="card">
<header class="card-header">

    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="float-right btn btn-secondary" OnClick="LinkButton1_Click">X</asp:LinkButton>
<h4 class="card-title mt-2">Add New Item</h4>
</header>

<article class="card-body">

	<div class="form-group">
		<label>Name</label>
        <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Name"></asp:TextBox>	
		
		 
		</div> <!-- form-group end.// -->
		<div class="form-group">
		<label>Password</label>
		<asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
			<small class="form-text text-muted"> We'll never share your Password with anyone else.</small>
		</div> <!-- form-group end.// -->

	<div class="form-group">
		<label>Email</label>
			<asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" TextMode="Email" ></asp:TextBox>	
	</div> <!-- form-group end.// -->

	<div class="form-group">
		<label>Phone Number</label>
			<asp:TextBox ID="TextBox4" CssClass="form-control" runat="server" TextMode="Phone" ></asp:TextBox>	
	</div> <!-- form-group end.// -->

	<div class="form-group">
		<asp:RadioButton ID="RadioButton1" runat="server" GroupName="type" Text="ADMIN" />
		<asp:RadioButton ID="RadioButton2" runat="server" GroupName="type" Text="USER"/>
		<br />
		<asp:Label ID="lblError" CssClass="text-danger" runat="server" Visible="false"></asp:Label>
	</div> <!-- form-group end.// -->


	<br />
	<br />

	 <div class="form-group">
		 <asp:Button CssClass="btn btn-primary btn-block" ID="btnAddUser" type="submit" runat="server" Text="Add User" OnClick="btnAddUser_Click"/>
    </div> <!-- form-group// -->   
                   

</article> <!-- card-body end .// -->
</div> <!-- card.// -->
</div> <!-- col.//-->

</div> <!-- row.//-->

</div>
</form>
<br />
<br />
<br />


  
  
</body>
</html>

