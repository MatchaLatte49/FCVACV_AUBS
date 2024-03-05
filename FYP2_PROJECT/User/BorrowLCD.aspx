<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="BorrowLCD.aspx.cs" Inherits="FYP2_PROJECT.User.BorrowLCD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
                <div class="container text-center">
                    <br />

                  <h2>Borrow Item</h2>
                     <a>Choose Item to Borrow</a>
                    <br />
                    <br />

                <div class="row ">
        
                <div class="card border border-dark shadow p-1 mb-5 bg-white rounded">
                  <div class="card-body">
                      <h5 class="card-title text-dark">LCD Projector</h5>
                      <p>LCD</p>
                     
                      <asp:Label ID="Label1" runat="server" Text="Choose LCD" Font-Bold="true"></asp:Label>
                      <br />
                      <asp:DropDownList ID="LCDlist" CssClass="custom-select w-25 p-1" runat="server">
                      </asp:DropDownList>

                    </div>
               
                    <div class="col-auto my-1">
                          <label>DateStart</label>
                        <br />
                      <asp:TextBox ID="TextBox1" CssClass="custom-select w-25 p-1" type="datetime-local" runat="server"></asp:TextBox>
                        </div>
                    <div class="col-auto my-1">
                           <label>DateEnd</label>
                        <br />
                        <asp:TextBox ID="TextBox2" CssClass="custom-select w-25 p-1" type="datetime-local" runat="server"></asp:TextBox>
                      
                        </div>
                    
                    <br />

                        <div class="col-auto my-1">
                            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" CssClass="btn btn-primary w-25" OnClick="ButtonSubmit_Click"/>
                            <asp:Label ID="LblMessage" runat="server"></asp:Label>
                        </div>

                      <br />
                  </div>
                </div>
                     <a href="/User/RequestItem.aspx"><< Back</a><br><br>
    </div>
            

   

</asp:Content>
