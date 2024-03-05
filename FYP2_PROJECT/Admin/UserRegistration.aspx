<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="UserRegistration.aspx.cs" Inherits="FYP2_PROJECT.UserRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <br />
                        <br />
                        <br />

   <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Register New User</h4>
                        </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Name"></asp:TextBox>
                        </div>
                     </div>
                      <div class="col-md-6">
                        <label>Email</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Phone No</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Contact No" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <span class="badge badge-pill badge-info">Login Credentials</span>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-5">
                        <label>User ID</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="User ID" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-5">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox10" runat="server" placeholder="Email ID" TextMode="Password"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                         
                        <br />
                   <div class="row">
                    <div class="col-md-4">
                        <label>User Type</label>
                        <div class="form-group">
                            <asp:RadioButtonList ID="UserType" runat="server">
                                          <asp:ListItem Text="Admin"/>
                                          <asp:ListItem Text="User"/> 
                            </asp:RadioButtonList>
                        </div>
                     </div>
                  </div>
                   
                        <br />

                        <div class="form-group">
                                    <div class="d-grid gap-2 col-6 mx-auto">
                                        <asp:Button class="btn btn-dark btn-lg" ID="BtnReg"
                                            runat="server" Text="Submit" />
                                    </div>
                                </div>

            
            </div>
           
         </div>
        
      </div>
   </div>
       <br />
       <br />

</asp:Content>
