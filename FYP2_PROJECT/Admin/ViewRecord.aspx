<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="ViewRecord.aspx.cs" Inherits="FYP2_PROJECT.Admin.ViewRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    
         <div class="container text-center">
             <br />
             <br />
             <br />
             <br />
             <h2>Record</h2>
         
             <br />
             <br />
             <div class="row">
              <div class="col">
               
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">LCD/Projector Record</h5>
                      
                      <a href="/Admin/LCDRecord.aspx"> <img class="w-50 p-3" src="../icon/projector.png" /><asp:Label ID="lblLCD" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                      <br />
                  </div>
                </div>
              </div>
             <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body ">
                      <h5 class="card-title text-dark">Accessories Record</h5>
                      <a href="/Admin/AccsRecord.aspx"> <img class="w-50 p-3" src="../icon/hdmi-cable.png" /><asp:Label ID="lblAccs" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                      <br />
                  </div>
                </div>
              </div>
         
              <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">BK Record</h5>
                      <a href="/Admin/BKRecord.aspx"> <img class="w-50 p-3" src="../icon/key-chain.png" /><asp:Label ID="lblBK" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                  </div>
                </div>
              </div>
                 <div class="col">
                <div class="card border border-dark shadow p-3 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">LAB Record</h5>
                      <a href="/Admin/LABRecord.aspx"> <img class="w-50 p-3" src="../icon/computer.png" /><asp:Label ID="lblLAB" CssClass="p-2 badge rounded-pill badge-notification bg-danger" runat="server" visible="false"></asp:Label></a>
                  </div>
                </div>
              </div>
            </div>
             </div>


</asp:Content>
