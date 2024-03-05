<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="LCD.aspx.cs" Inherits="FYP2_PROJECT.Admin.LCD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <!-- Modal -->
            <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                    <button type="button" class="btn-close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true"></span>
                    </button>
                  </div>
                  <div class="modal-body">
                       <div class="form-group">
                        <label for="exampleInputEmail1">LCD Name</label>
                         <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="example.. LCD000"></asp:TextBox>
                        <small id="ImageName" class="form-text text-muted">Input LCD Name</small>
                      </div>
                  </div>
                  <div class="modal-footer">
                    <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server"  data-dismiss="modal" Text="Close" />
                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server"  OnClick="btnAddItem_Click" Text="Submit" />
                  </div>
                </div>
              </div>
            </div>

     <!-- Main Page -->
                

         <div class="container text-center">
             <br />
             <br />
             <br />
             <br />
             <h2>LCD List</h2>
         
             <br />
             <br />
             <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">
              Insert New LCD
            </button>
            <br />

    <div class="row rounded mt-2 border border-dark bg-light"> 
                 
        <asp:GridView ID="GridView1" CssClass="table table-bordered border-dark"  HeaderStyle-BackColor="#212529" HeaderStyle-ForeColor="#FFFFFF" runat="server" AutoGenerateColumns="False" DataKeyNames="LCDID" OnRowDataBound="GridView1_RowDataBound"
            OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
             <Columns>
                 <asp:BoundField DataField="LCD_ID" HeaderText="LCDID" ReadOnly="True"></asp:BoundField>
                 <asp:BoundField DataField="LCDname"  HeaderText="NAME"></asp:BoundField>
                 <asp:BoundField DataField="date_add" HeaderText="Date Add" ReadOnly="True"  ></asp:BoundField>
                 <asp:BoundField DataField="status"  HeaderText="Status"></asp:BoundField>
                 <asp:CommandField ShowEditButton="True" ButtonType="Button">
                     <ControlStyle CssClass="btn btn-success btn-sm"></ControlStyle></asp:CommandField>

             <asp:CommandField ShowDeleteButton="True" ButtonType="Button">
                 <ControlStyle CssClass="btn btn-danger btn-sm"></ControlStyle></asp:CommandField></Columns>
         </asp:GridView>
                     </div>
                
             </div>
    

     <script type="text/javascript">
         $(document).ready(function () {
             $('#<%= GridView1.ClientID %>').DataTable();
         });
     </script>


</asp:Content>
