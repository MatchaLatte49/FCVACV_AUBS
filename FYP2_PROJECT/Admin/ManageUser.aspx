<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="ManageUser.aspx.cs" Inherits="FYP2_PROJECT.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
      <center>
        
          <br />
 
           <div class="container-lg text-center">
             
             <h2>Manage User</h2>
                    
                     <br />
               <br />
             <div class="row"> 
                 <div class="col">
                     
                     
              <asp:LinkButton ID="LinkAddUser" runat="server" OnClick="LinkAddUser_Click" CssClass="btn btn btn-primary">Add User</asp:LinkButton>
             <br />
                     </div>

                 <div class="row rounded mt-2 border"> 
                     <asp:GridView ID="GridView1" CssClass="table" HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="False" DataKeyNames="UserID"
                         OnRowDataBound="GridView1_RowDataBound" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
              <Columns> 
                  <asp:BoundField DataField="CUID" HeaderText="CUID" ReadOnly="True"/>
                  <asp:BoundField DataField="UserNAME" HeaderText="NAME" />
                  <asp:BoundField DataField="UserPASSWORD" HeaderText="PASSWORD" />
                  <asp:BoundField DataField="UserEMAIL" HeaderText="EMAIL" />
                  <asp:BoundField DataField="UserPHONE" HeaderText="PHONE" />
                  <asp:BoundField DataField="UserROLES" HeaderText="Roles" />
                  <asp:BoundField DataField="create_at" HeaderText="Create Date " ReadOnly="True" />

              <asp:CommandField ShowEditButton="True" ButtonType="Button"><ControlStyle CssClass="btn btn-success btn-sm"></ControlStyle> </asp:CommandField>
              <asp:CommandField ShowDeleteButton="True" ButtonType="Button"><ControlStyle CssClass="btn btn-danger btn-sm"></ControlStyle></asp:CommandField>


              </Columns>
              


          </asp:GridView>


            </div>
          </div>
        </div>
          
       
          <script type="text/javascript">
         $(document).ready(function () {
             $('#<%= GridView1.ClientID %>').DataTable();
         });
          </script>




          </center>

</asp:Content>
