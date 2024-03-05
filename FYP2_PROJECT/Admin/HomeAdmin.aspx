<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="FYP2_PROJECT.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container text-center">
             <br />
        <img  src="../icon/FCVAClogo.png" />
             <br />
        <br />
            
           <h5 class="text-dark">FCVAC AUTOMATED BORROWING MANAGING SYSTEM</h5>
    
        <br />
       
         <a>Hello <asp:Label CssClass="text-dark" ID="lblUsername" runat="server"></asp:Label></a>
             <br />
             
             <div class="row">
              <div class="col">
               <div class="card border border-dark shadow p-3 mb-5  rounded" >
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Manage Request</h5>
                      <a href="/Admin/ManageRequest.aspx"><img class="w-50 p-3" src="../icon/deal.png" /><asp:Label ID="lbltotal" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                      
                      <br />
                  </div>
                </div>
              </div>
                 <div class="col">
               <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Manage Return</h5>
                      <a href="/Admin/ManageReturn.aspx"> <img class="w-50 p-3" src="../icon/return_item.png" /><asp:Label ID="lbltotal2" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                      
                      <br />
                  </div>
                </div>
              </div>
              <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">View Record</h5>
                      <a href="/Admin/ViewRecord.aspx"> <img class="w-50 p-3" src="../icon/check-list.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
                 
            </div>
        <br />
      

        <div class="row">
              <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Manage User</h5>
                      <a href="/Admin/ManageUser.aspx"> <img class="w-50 p-3" src="../icon/user.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
              <div class="col">
              <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                       <h5 class="card-title text-dark">Manage Schedule</h5>
                      <a href="/Admin/ManageSchedule.aspx"> <img class="w-50 p-3" src="../icon/calendar.png" /></a>
                      
                      <br />
                  </div>
                </div>
              </div>
                 <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                       <h5 class="card-title text-dark">Manage Inventory</h5>
                      <a href="/Admin/inventory.aspx"> <img class="w-50 p-3" src="../icon/inventory.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
            </div>
        </div>
    <br />
             <br />
    <br />
             <br />
    <br />
             <br />

</asp:Content>
