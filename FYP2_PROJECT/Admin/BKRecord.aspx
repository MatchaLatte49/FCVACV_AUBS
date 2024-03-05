<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="BKRecord.aspx.cs" Inherits="FYP2_PROJECT.Admin.BKRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container text-center">
             <br />
             <br />
            
             <h2>BK Record</h2>
         
             <br />
             <br />
             
         <asp:Button ID="Button1" CssClass="btn btn-primary w-25" runat="server" Text="Export to PDF" OnClick="ExportToPDF_Click" />
     
    <div class="row rounded mt-2 ">
        
        <asp:Label ID="Label1" runat="server" Visible="true" Text="No Data"></asp:Label>
    <asp:GridView ID="GridView1" CssClass="table table-bordered border-dark" runat="server" AutoGenerateColumns="false" HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" OnRowDataBound="GridView1_RowDataBound" >
        <Columns>
            <asp:BoundField DataField="RequestBKID" HeaderText="reqID" />
            <asp:BoundField DataField="bkID" HeaderText="bkID" />
            <asp:BoundField DataField="bkName" HeaderText="bkName" />
            <asp:BoundField DataField="UserID" HeaderText="UserID" />
            <asp:BoundField DataField="UserName" HeaderText="Name" />
            <asp:BoundField DataField="UserPhoneNumber" HeaderText="Phone" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" />
            <asp:BoundField DataField="RequestDate" HeaderText="Request" />
            <asp:BoundField DataField="StartDate" HeaderText="Start" />
            <asp:BoundField DataField="EndDate" HeaderText="End" />
             <asp:BoundField DataField="ReturnDate" HeaderText="Return" />
            <asp:BoundField DataField="takenVerified" HeaderText="Verified By (taken)" />
            <asp:BoundField DataField="ReturnVerified" HeaderText="Verified By (return)" />
        </Columns>

    </asp:GridView>  
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
             
     <script type="text/javascript">
         $(document).ready(function () {
             $('#<%= GridView1.ClientID %>').DataTable({
                  paging: false,
                  ordering: false,
                  info: false,
              });
          });
     </script>
</asp:Content>
