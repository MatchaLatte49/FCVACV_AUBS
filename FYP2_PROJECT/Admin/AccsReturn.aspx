<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="AccsReturn.aspx.cs" Inherits="FYP2_PROJECT.Admin.AccsReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


     <div class="container text-center">
             <br />
             <br />
            
             <h2>Manage Accessories Return </h2>
         <a> Click "RETURN" when borrower return the item</a>
             <br />
             <br />

           <h5> Return Accessories </h5>
           <div class="row rounded mt-2 border border-dark bg-white"> 
               
                <asp:Label ID="Label2" runat="server" Visible="true" Text="No Data"></asp:Label>
    <asp:GridView ID="GridView2" CssClass="table table-bordered border-dark"  HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView2_RowCommand" OnRowDataBound="GridView2_RowDataBound">
        <Columns>
            <asp:BoundField DataField="RequestAccsID" HeaderText="ID" />
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
            <asp:TemplateField HeaderText="Item Return">
            <ItemTemplate>
                <asp:Button ID="btnItemReturn" CssClass="btn btn-success" runat="server" Text="Item Return" CommandName="ItemReturn" CommandArgument='<%# Eval("RequestAccsID") %>' />
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
            $('#<%= GridView2.ClientID %>').DataTable();
         });
     </script>

</asp:Content>
