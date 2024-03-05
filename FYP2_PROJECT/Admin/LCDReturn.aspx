<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="LCDReturn.aspx.cs" Inherits="FYP2_PROJECT.Admin.LCDReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">




    
     <div class="container text-center">
             <br />
             <br />
            
             <h2>Manage Return LCD</h2>
         <a> Click "RETURN" when borrower return the item</a>
             <br />
             <br />

     <%-- LCD TABLE --%>
     <h5> Return LCD </h5>
    <div class="row rounded mt-2 border border-dark bg-white"> 
         
        <asp:Label ID="Label1" runat="server" Visible="true" Text="No Data"></asp:Label>
   <asp:GridView ID="GridView1" CssClass="table table-bordered border-dark"  HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView1_RowCommand" OnRowDataBound="GridView1_RowDataBound">
    <Columns>
        <asp:BoundField DataField="RequestLCDID" HeaderText="ID" />
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
        <asp:TemplateField HeaderText="Item Return">
            <ItemTemplate>
                <asp:Button ID="btnItemReturn" CssClass="btn btn-success" runat="server" Text="Item Return" CommandName="ItemReturn" CommandArgument='<%# Eval("RequestLCDID") %>' />
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


    <script type="text/javascript">
         $(document).ready(function () {
             $('#<%= GridView1.ClientID %>').DataTable();
         });
    </script>


</asp:Content>
