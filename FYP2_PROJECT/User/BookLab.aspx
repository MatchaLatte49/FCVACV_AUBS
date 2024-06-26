﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="BookLab.aspx.cs" Inherits="FYP2_PROJECT.User.BookLab" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container text-center">
                    <br />

                  <h2>Book Computer Lab</h2>
                     
                    <br />
                    <br />

                <div class="row ">
        
                <div class="card border border-dark shadow p-1 mb-5 bg-white rounded">
                  <div class="card-body">

                      <h5 class="card-title text-dark">BOOKING LAB</h5>
                      <p>Search Schedule</p>
                     <asp:DropDownList ID="ddlImageNames" CssClass="custom-select w-25 p-1" runat="server">
                             <asp:ListItem Text="Select Schedule" Value="" />
                     </asp:DropDownList>
                        <asp:Button ID="btnShowSchedule" runat="server" CssClass="btn btn-dark" Text="Show Schedule" OnClick="btnShowImage_Click" />
                        <br />
                      <br />
                      <div class="card border border-dark">
                       <%--Image Display--%>
                          <asp:Label ID="labelImage" runat="server" Visible="true" Text="No Image"> </asp:Label>
                        <asp:Image ID="imgSelectedImage" CssClass="img-fluid" runat="server" Visible="false" />
                      </div>
                      <br />
                      <br />

                    <%--ItemList--%>
                      <div class="col-auto my-1">
                          <label>Select Lab</label>
                          <br />
                          <asp:DropDownList ID="itemlist" runat="server" CssClass="custom-select w-25 p-1" AppendDataBoundItems="true">
                              <asp:ListItem Text="Select Lab" Value="" />
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
                            <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" CssClass="btn btn-primary w-25"  OnClick="ButtonSubmit_Click"/>
                            <asp:Label ID="LblMessage" runat="server"></asp:Label>
                        </div>

                      <br />
                      </div>
                  </div>
                </div>
           <a href="/User/RequestItem.aspx"><< Back</a><br><br>
    </div>
   
</asp:Content>
