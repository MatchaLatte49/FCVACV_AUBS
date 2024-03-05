<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="Inventory.aspx.cs" Inherits="FYP2_PROJECT.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
          

         <div class="container text-center">
             <br />
             <br />
             <br />
             <br />
             <h2>Inventory List</h2>
         
             <br />
             <br />
             <div class="row">
              <div class="col">
               
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Manage LCD</h5>
                      <a href="/Admin/LCD.aspx"> <img class="w-50 p-3" src="../icon/projector.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
             <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Manage Accessories</h5>
                      <a href="/Admin/Accessories.aspx"> <img class="w-50 p-3" src="../icon/hdmi-cable.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
              <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">Manage BK key</h5>
                      <a href="/Admin/BKkeys.aspx"> <img class="w-50 p-3" src="../icon/key-chain.png" /></a>
                  </div>
                </div>
              </div>
                 <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">Manage Lab Key</h5>
                      <a href="/Admin/LabKey.aspx"> <img class="w-50 p-3" src="../icon/computer.png" /></a>
                  </div>
                </div>
              </div>
            </div>
             </div>




             
</asp:Content>
