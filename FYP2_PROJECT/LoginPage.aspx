<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="FYP2_PROJECT.LoginPage" %>
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
                                    <h3>LOGIN</h3>
                                </center>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                          <div class="row">
                            <div class="col">
                                    <hr>

                            </div>
                           
                           
                        </div>

                          <div class="row">
                            <div class="col">

                                  <label>User ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextStyle1"  runat="server" 
                                        placeholder="UserID"></asp:TextBox>


                                </div>
                                <br />
            
                              
                                 <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextStyle2" runat="server" 
                                        placeholder="Password" TextMode="Password"></asp:TextBox>

                                </div>
                                <br />
                              
                                <div class="form-group">
                                    <div class="d-grid gap-2 col-6 mx-auto">
                                  
                                        <asp:Button class="btn btn-dark btn-lg" ID="Btn1"
                                            runat="server" Text="Login" OnClick="Btn1_Click" />
                                    </div>
                                </div>

                

                            </div>
                        </div>

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
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
