<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="BKReturn.aspx.cs" Inherits="FYP2_PROJECT.Admin.BKReturn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    
     <div class="container text-center">
             <br />
             <br />
            
             <h2>Manage Return BK keys</h2>
         <a> Click "RETURN" when borrower return the item</a>
             <br />
             <br />

     
         <h5>Return Bk</h5>
           <div class="row rounded mt-2 border border-dark bg-white"> 
               
                <asp:Label ID="Label4" runat="server" Visible="true" Text="No Data"></asp:Label>
    <asp:GridView ID="GridView4" CssClass="table table-bordered border-dark" HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="false" OnRowCommand="GridView4_RowCommand" OnRowDataBound="GridView4_RowDataBound">
        <Columns>
            <asp:BoundField DataField="RequestBKID" HeaderText="ID" />
            <asp:BoundField DataField="bkID" HeaderText="Name" />
            <asp:BoundField DataField="bkName" HeaderText="BKName" />
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
                <asp:Button ID="btnItemReturn" CssClass="btn btn-success"  runat="server" Text="Item Return" CommandName="ItemReturn" CommandArgument='<%# Eval("RequestBKID") %>' />
            </ItemTemplate>
        </asp:TemplateField>

        </Columns>

    </asp:GridView>  

               </div>
         </div>


    
    <script type="text/javascript">
        $(document).ready(function () {
            $('#<%= GridView4.ClientID %>').DataTable();
        });
    </script>

</asp:Content>
