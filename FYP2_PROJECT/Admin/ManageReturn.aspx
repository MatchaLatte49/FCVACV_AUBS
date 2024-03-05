<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="ManageReturn.aspx.cs" Inherits="FYP2_PROJECT.Admin.ManageReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

       <div class="container text-center">
             <br />
             <br />
             <br />
             <br />
             <h2>Manage Return</h2>
         
             <br />
             <br />
             <div class="row">
              <div class="col">
               
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Manage LCD <br> Return</h5>
                      <a href="/Admin/LCDReturn.aspx"> <img class="w-50 p-3" src="../icon/projector.png" /><asp:Label ID="lblLCD" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                      <br />
                  </div>
                </div>
              </div>
             <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Manage Accessories Return</h5>
                      <a href="/Admin/AccsReturn.aspx"> <img class="w-50 p-3" src="../icon/hdmi-cable.png" /><asp:Label ID="lblAccs" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                      <br />
                  </div>
                </div>
              </div>
              <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">Manage BK key <br> Return</h5>
                      <a href="/Admin/BKReturn.aspx"> <img class="w-50 p-3" src="../icon/key-chain.png" /><asp:Label ID="lblBK" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                  </div>
                </div>
              </div>
                 <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">Manage Lab Key <br> Return</h5>
                      <a href="/Admin/LabReturn.aspx"> <img class="w-50 p-3" src="../icon/computer.png" /><asp:Label ID="lblLAB" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                  </div>
                </div>
              </div>
            </div>
             </div>

    

</asp:Content>
