<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="LCDRequest.aspx.cs" Inherits="FYP2_PROJECT.Admin.LCDRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
         <div class="container text-center">
             <br />
             <br />
             <br />
             <br />
             <h2>LCD List</h2>
         
             <br />
             <br />

    <div class="row rounded mt-2 border border-dark bg-light"> 
                 <asp:Label ID="lbl1" runat="server" visible="true" Text="No Request"></asp:Label>
        <asp:GridView ID="GridView1" CssClass="table table-bordered border-dark" runat="server" AutoGenerateColumns="False" DataKeyNames="RequestLCDID" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand"  >
            <Columns>
                <asp:BoundField DataField="RequestLCDID" HeaderText="LCDID" ReadOnly="True"></asp:BoundField>
                 <asp:BoundField DataField="UserID" HeaderText="User ID"  ></asp:BoundField>
                 <asp:BoundField DataField="lcdID"  HeaderText="LCD ID"></asp:BoundField>
                 <asp:BoundField DataField="UserName" HeaderText="Name"></asp:BoundField>
                 <asp:BoundField DataField="UserPhoneNumber" HeaderText="Phone"></asp:BoundField>
                <asp:BoundField DataField="UserEmail" HeaderText="Email"></asp:BoundField>
                 <asp:BoundField DataField="RequestDate" HeaderText="Request Date" ReadOnly="True"  ></asp:BoundField>
                 <asp:BoundField DataField="StartDate" HeaderText="Start" ReadOnly="True"  ></asp:BoundField>
                 <asp:BoundField DataField="EndDate" HeaderText="Return" ReadOnly="True"  ></asp:BoundField>
                 <asp:BoundField DataField="Status" HeaderText="Status"  ></asp:BoundField>
                  <asp:TemplateField HeaderText="Approve">
                     <ItemTemplate>
                        <asp:Button ID="btnApprove" runat="server" Text="Approve" CssClass="btn btn-success" CommandName="Approve" CommandArgument='<%# Eval("RequestLCDID") %>' />
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Reject">
                     <ItemTemplate>
                        <asp:Button ID="btnReject" runat="server" Text="Reject" CssClass="btn btn-danger" CommandName="Reject" CommandArgument='<%# Eval("RequestLCDID") %>' />
                     </ItemTemplate>
                  </asp:TemplateField>

             </Columns>
         </asp:GridView>
                     </div>
                
             </div>


    

     <script type="text/javascript">
         $(document).ready(function () {
             $('#<%= GridView1.ClientID %>').DataTable();
         });
     </script>
</asp:Content>
