<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="BKRequest.aspx.cs" Inherits="FYP2_PROJECT.Admin.BKRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container text-center">
             <br />
             <br />
             <br />
             <br />
             <h2>Request BK List</h2>
         
             <br />
             <br />

    <div class="row rounded mt-2 border border-dark bg-light"> 
                 <asp:Label ID="lbl1" runat="server" visible="true" Text="No Request"></asp:Label>
         <asp:GridView  ID="GridView1" CssClass="table table-bordered border-dark" runat="server" AutoGenerateColumns="False" DataKeyNames="RequestBKID" OnRowDataBound="GridView1_RowDataBound" OnRowCommand="GridView1_RowCommand" >
             <Columns>
                 <asp:BoundField DataField="RequestBKID" HeaderText="ID" ReadOnly="True"></asp:BoundField>
                 <asp:BoundField DataField="UserID" HeaderText="User ID"  ></asp:BoundField>
                 <asp:BoundField DataField="bkID"  HeaderText="Accs ID"></asp:BoundField>
                 <asp:BoundField DataField="UserName" HeaderText="Name" />
                 <asp:BoundField DataField="UserPhoneNumber" HeaderText="Phone" />
                 <asp:BoundField DataField="RequestDate" HeaderText="Request Date" ReadOnly="True"  ></asp:BoundField>
                 <asp:BoundField DataField="StartDate" HeaderText="Start" ReadOnly="True"  ></asp:BoundField>
                 <asp:BoundField DataField="EndDate" HeaderText="Return" ReadOnly="True"  ></asp:BoundField>
                 <asp:BoundField DataField="Status" HeaderText="Status"  ></asp:BoundField>
                  <asp:TemplateField HeaderText="Approve">
                     <ItemTemplate>
                        <asp:Button ID="btnApprove" runat="server" CssClass="btn btn-success" Text="Approve" CommandName="Approve" CommandArgument='<%# Eval("RequestBKID") %>' />
                     </ItemTemplate>
                  </asp:TemplateField>
                  <asp:TemplateField HeaderText="Reject">
                     <ItemTemplate>
                        <asp:Button ID="btnReject" runat="server" CssClass="btn btn-danger" Text="Reject" CommandName="Reject" CommandArgument='<%# Eval("RequestBKID") %>' />
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
