<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="userPage.aspx.cs" Inherits="FYP2_PROJECT.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div class="container-lg ">
     <div class="position-relative overflow-hidden text-center">
      
  <img  src="../icon/FCVAClogo.png" />
  <br />
  <br />
  
     <br />
      
    
    <p class="lead font-weight-normal ">FCVAC AUTOMATED BORROWING SYSTEM</p>
    <p class="lead font-weight-normal ">Hello <asp:Label ID="Label1" runat="server"></asp:Label></p>
  

      
    </div>

    <div class="row gy-4 mt-5 text-center">
        <div class="col-xl-3 col-md-6" >
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Borrow Item/Book Class</h5>
                      <a href="/User/RequestItem.aspx"> <img class="w-50 p-3" src="../icon/booking.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
             <div class="col-xl-3 col-md-6">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">My Request</h5>
                      <a href="/User/MyRequests.aspx"> <img class="w-50 p-3" src="../icon/borrowing.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
         
              <div class="col-xl-3 col-md-6">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">Account Setting</h5>
                      <a href="/User/Setting.aspx"> <img class="w-50 p-3" src="../icon/settings.png" /></a>
                  </div>
                </div>
              </div>
         <div class="col-xl-3 col-md-6">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">Logout</h5>
                      <asp:LinkButton ID="LinkLogout" runat="server" OnClick="LinkLogout_Click"><img class="w-50 p-3" src="../icon/logout.png" /> </asp:LinkButton> 
                  </div>
                </div>
              </div>
                 
        </div>
        </div>

   
       
     








</asp:Content>
