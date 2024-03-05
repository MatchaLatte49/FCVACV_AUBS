<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Setting.aspx.cs" Inherits="FYP2_PROJECT.User.Setting" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



     <div class="container text-center">
         <br />
         <br />

         <br />

             <div class="row justify-content-center d-flex">
         
            <div class="card shadow p-1 mb-5">
               <div class="card-body ">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Your Profile</h4>
                            <p class="lead font-weight-normal"><asp:Label ID="Label1" CssClass="bg-success text-white" runat="server"></asp:Label></p>
                           
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                   <br />
                  <div class="row">
                     <div class="col-md-6">
                        <label>Full Name</label>
                        <div class="form-group-lg">
                           <asp:TextBox CssClass="form-control" ID="TextBoxName" runat="server" placeholder="Full Name" ></asp:TextBox>
                        </div>
                     </div>
                    <div class="col-md-6">
                        <label>Email </label>
                        <div class="form-group-lg">
                           <asp:TextBox CssClass="form-control" ID="TextBoxEmail" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <br />
                  <div class="row">
                     <div class="col-md-6">
                        <label>Contact No</label>
                        <div class="form-group-lg">
                           <asp:TextBox CssClass="form-control" ID="TextBoxContact" runat="server" placeholder="Contact No" TextMode="Phone"></asp:TextBox>
                        </div>
                     </div>
                      
                  </div>
                   <br />
                                          <hr />
                                         
                   <asp:Button ID="btnUpdateDetails" class="btn btn-primary btn-lg" runat="server" Text="Update Details" OnClick="btnUpdateDetails_Click" />
                    
                   <hr />
                   
                  <div class="row">
                     <div class="col-md">
                        <label>Old Password</label>
                        <div class="form-group-lg">
                           <asp:TextBox class="form-control" ID="TextBoxOldPassword" runat="server" placeholder="Old Password" TextMode="Password" ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md">
                        <label>New Password</label>
                        <div class="form-group-lg">
                           <asp:TextBox class="form-control" ID="TextBoxNewPassword" runat="server" placeholder="New Password" TextMode="Password"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <br />
                   <br />
                    <hr />
                  <div class="row">
                     <div class="col-8 mx-auto">
                        <center>
                           <div class="form-group">
                              <asp:Button class="btn btn-primary btn-lg" ID="Button1" runat="server" Text="Update Password" OnClick="btnUpdatePassword_Click" />
                           </div>
                        </center>
                     </div>
                  </div>
               </div>
            </div>
            <a href="/User/userPage.aspx"><< Back to Home</a><br><br>
         </div>
        
      
         </div>
</asp:Content>
