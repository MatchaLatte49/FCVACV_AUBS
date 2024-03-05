<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="MyRequests.aspx.cs" Inherits="FYP2_PROJECT.User.MyRequests" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <div class="container text-center">
          <div class="table-responsive">
             <br />
             <br />
            
             <h2>My Request</h2>
         <a>Please Take Your Item If Status is "PENDING"</a>
             <br />
              <a href="/User/RequestItem.aspx"><< Back</a><br><br>
             <br />
             
     <h5>LCD </h5>
    <div class="row"> 
        <br />
        <asp:Label ID="Label1" runat="server" Visible="true" Text="No Data"></asp:Label>
    <asp:GridView ID="GridView1" CssClass="table table-bordered border-dark table-responsive" HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" OnRowCancelingEdit="GridView1_RowCancelingEdit">
        <Columns>
            <asp:BoundField DataField="RequestLCDID" HeaderText="ReqID" />
            <asp:BoundField DataField="lcdID" HeaderText="LCDID" />
            <asp:BoundField DataField="lcdName" HeaderText="LCDName" />
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="UserName" HeaderText="Name" />
            <asp:BoundField DataField="UserPhoneNumber" HeaderText="Phone" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" />
            <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" />
            <asp:BoundField DataField="StartDate" HeaderText="Start" />
            <asp:BoundField DataField="EndDate" HeaderText="Return" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:TemplateField HeaderText="Cancel">
            <ItemTemplate>
                <asp:Button ID="btnCancel" CssClass="btn btn-danger"  runat="server" Text="cancel" CommandName="Cancel" CommandArgument='<%# Eval("RequestLCDID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>

    </asp:GridView>  
        </div>
           <br />
           <br />
           <br />
           <br />
           <h5>Accessories </h5>
          <div class="row"> 
              <br />
               <asp:Label ID="Label2" runat="server" Text="No Data" ></asp:Label>
    <asp:GridView ID="GridView2" CssClass="table table-bordered border-dark" HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView2_RowCommand" OnRowCancelingEdit="GridView2_RowCancelingEdit">
        <Columns>
            <asp:BoundField DataField="RequestAccsID" HeaderText="ReqID" />
            <asp:BoundField DataField="AccsID" HeaderText="AccsID" />
            <asp:BoundField DataField="AccsName" HeaderText="AccsName" />
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="UserName" HeaderText="Name" />
            <asp:BoundField DataField="UserPhoneNumber" HeaderText="Phone" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" />
            <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" />
            <asp:BoundField DataField="StartDate" HeaderText="Start" />
            <asp:BoundField DataField="EndDate" HeaderText="Return" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
            <asp:TemplateField HeaderText="Cancel">
            <ItemTemplate>
                <asp:Button ID="btnCancel" CssClass="btn btn-danger"  runat="server" Text="cancel" CommandName="Cancel" CommandArgument='<%# Eval("RequestAccsID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>

    </asp:GridView>  
        </div>
          <br />
           <br />
           <br />
           <br />
           
          <h5>Request LAB</h5>
           <div class="row"> 
             <br />
               <asp:Label ID="Label3" runat="server" Text="No Data"></asp:Label>
    <asp:GridView ID="GridView3" CssClass="table table-bordered border-dark" HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView3_RowCommand" OnRowCancelingEdit="GridView3_RowCancelingEdit">
        <Columns>
            <asp:BoundField DataField="RequestLABID" HeaderText="ReqID" />
            <asp:BoundField DataField="labID" HeaderText="LabID" />
            <asp:BoundField DataField="labName" HeaderText="LabName" />
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="UserName" HeaderText="Name" />
            <asp:BoundField DataField="UserPhoneNumber" HeaderText="Phone" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" />
            <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" />
            <asp:BoundField DataField="StartDate" HeaderText="Start" />
            <asp:BoundField DataField="EndDate" HeaderText="Return" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
             <asp:TemplateField HeaderText="Cancel">
            <ItemTemplate>
                <asp:Button ID="btnCancel" CssClass="btn btn-danger"  runat="server" Text="cancel" CommandName="Cancel" CommandArgument='<%# Eval("RequestLABID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>

    </asp:GridView>  
        </div>


           <br />
           <br />
           <br />
           <br />

          <h5>Request Bk</h5>
           <div class="row-fluid"> 
               <br />
               <asp:Label ID="Label4" runat="server" Text="No Data"></asp:Label>
               
    <asp:GridView ID="GridView4" CssClass="table table-bordered border-dark" HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView4_RowCommand" OnRowCancelingEdit="GridView4_RowCancelingEdit">
        <Columns>
            <asp:BoundField DataField="RequestBKID" HeaderText="ReqID" />
            <asp:BoundField DataField="bkID" HeaderText="BK ID" />
            <asp:BoundField DataField="bkName" HeaderText="BK Name" />
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="UserName" HeaderText="Name" />
            <asp:BoundField DataField="UserPhoneNumber" HeaderText="Phone" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" />
            <asp:BoundField DataField="RequestDate" HeaderText="RequestDate" />
            <asp:BoundField DataField="StartDate" HeaderText="Start" />
            <asp:BoundField DataField="EndDate" HeaderText="Return" />
            <asp:BoundField DataField="Status" HeaderText="Status" />
             <asp:TemplateField HeaderText="Cancel">
            <ItemTemplate>
                <asp:Button ID="btnCancel" CssClass="btn btn-danger"  runat="server" Text="cancel" CommandName="Cancel" CommandArgument='<%# Eval("RequestBKID") %>' />
            </ItemTemplate>
        </asp:TemplateField>
        </Columns>

    </asp:GridView>  

        </div>
          
         <br />
         <br />

         <br />
         <br />
         <br />
              </div>
        </div>
</asp:Content>
