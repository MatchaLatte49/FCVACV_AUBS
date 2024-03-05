<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="RequestItem.aspx.cs" Inherits="FYP2_PROJECT.User.RequestItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="container text-center">
        <br />

      <h2>Borrow Item</h2>
         <a>Choose Item to Borrow</a>

    <div class="row gy-4 mt-5">
        
        <div class="col-xl-3 col-md-6" >
                <div class="card border border-dark shadow p-1 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">LCD Projector</h5>
                      <p>LCD</p>
                      <a href="/User/BorrowLCD.aspx"> <img class="w-50 p-3" src="../icon/projector.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
             <div class="col-xl-3 col-md-6">
                <div class="card border border-dark shadow p-1 mb-5 bg-white rounded ">
                  <div class="card-body">
                      <h5 class="card-title text-dark">Accessories</h5>
                      <p>HDMI, extension, cable</p>
                      <a href="/User/BorrowAccs.aspx"> <img class="w-50 p-3" src="../icon/hdmi-cable.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
        <div class="col-xl-3 col-md-6" >
                <div class="card border border-dark shadow p-1 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">Computer Lab</h5>
                      <p>Choose lab</p>
                      <a href="/User/BookLab.aspx"> <img class="w-50 p-3" src="../icon/computer.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
             <div class="col-xl-3 col-md-6">
                <div class="card border border-dark shadow p-1 mb-5 bg-white rounded ">
                  <div class="card-body">
                      <h5 class="card-title text-dark">BK Class</h5>
                      <p>Choose BK</p>
                      <a href="/User/BookBK.aspx"> <img class="w-50 p-3" src="../icon/classroom.png" /></a>
                      <br />
                  </div>
                </div>
              </div>
         
        </div>
</div>




</asp:Content>
