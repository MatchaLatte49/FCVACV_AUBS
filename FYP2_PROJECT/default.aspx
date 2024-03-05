<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="FYP2_PROJECT.LoginEmail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <%--bootstrap--%>
      
   
    <link href="Content/bootstrap-grid.css" rel="stylesheet" />
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-reboot.css" rel="stylesheet" />
    <link href="Content/bootstrap-reboot.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/esm/popper-utils.js"></script>
    <script src="Scripts/esm/popper-utils.min.js"></script>
    <script src="Scripts/esm/popper.js"></script>
    <script src="Scripts/esm/popper.min.js"></script>

    <script src="Scripts/src/index.js"></script>
    <script src="Scripts/bootstrap.bundle.js"></script>
    <script src="Scripts/bootstrap.bundle.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-3.0.0-vsdoc.js"></script>
    <script src="Scripts/jquery-3.0.0.js"></script>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/jquery-3.0.0.slim.js"></script>
    <script src="Scripts/jquery-3.0.0.slim.min.js"></script>
    <script src="Scripts/popper-utils.js"></script>
    <script src="Scripts/popper-utils.min.js"></script>
    <script src="Scripts/popper.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <link rel="canonical" href="https://getbootstrap.com/docs/4.0/examples/navbars/"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <link rel="icon" href="/docs/4.0/assets/img/favicons/favicon.ico"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
       <section class="vh-100" style="background-color: #ffffff;">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col col-xl-10">
        <div class="card" style="border-radius: 1rem;">
          <div class="row g-0">
            <div class="col-md-6 col-lg-5 d-none d-md-block">
              <img src="icon/AUBS.svg"
                alt="login form" class="img-fluid" style="border-radius: 1rem 0 0 1rem;" />
            </div>
            <div class="col-md-6 col-lg-7 d-flex align-items-center">
              <div class="card-body p-4 p-lg-5 text-black">
                   
                  <div class="d-flex align-items-center mb-3 pb-1">
                    
                    <span class="h1 fw-bold mb-0">Login</span>
                  </div>

                  

                  <div class="form-outline mb-4">
                      <h5 class="fw-normal" style="letter-spacing: 1px;">Insert your Email</h5>
                     <asp:TextBox  ID="TextStyle1" CssClass="form-control form-control-lg"  runat="server" placeholder="Email"></asp:TextBox>
                    
                  </div>

                  <div class="form-outline mb-4">
                    <h5 class="fw-normal" style="letter-spacing: 1px;">Password</h5>
                    <asp:TextBox  ID="TextStyle2" CssClass="form-control form-control-lg" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                  </div>
                  <div class="pt-1 mb-4">
                       <asp:Button CssClass="btn btn-dark btn-lg btn-block" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                  </div>  
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
    </form>
</body>
</html>
