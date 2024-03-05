<%@ Page Title="" Language="C#" MasterPageFile="~/AdminDashboard.Master" AutoEventWireup="true" CodeBehind="ManageSchedule.aspx.cs" Inherits="FYP2_PROJECT.Admin.ManageSchedule" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <!-- Modal -->
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
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
                        <label for="exampleInputEmail1">Name</label>
                        <asp:TextBox ID="TxtName" CssClass="form-control" runat="server"></asp:TextBox>
                        <small id="ImageName" class="form-text text-muted">Input Image Name</small>
                      </div>
                      <div class="form-group">
                        <label for="exampleInputEmail1">Select type</label>
                       <asp:DropDownList ID="ddlItems" CssClass="form-control" runat="server">
                            <asp:ListItem Value="BK">BK</asp:ListItem>
                            <asp:ListItem Value="LAB">LAB</asp:ListItem>
                        </asp:DropDownList>
                        <small id="imageType" class="form-text text-muted">Input Image Name</small>
                      </div>
                      <div class="form-group">
                        <label for="uploadImage">UploadImage</label>
                        <asp:FileUpload ID="fileUpload" CssClass="form-control-file" runat="server" /> 
                        
                      </div>
                  </div>
                  <div class="modal-footer">
             
                      <asp:Button ID="Button2" CssClass="btn btn-danger" runat="server"  data-dismiss="modal" Text="Close" />
                    <asp:Button ID="Button1" CssClass="btn btn-primary" runat="server" onclick="Button1_Click" Text="Upload" />
                  </div>
                </div>
              </div>
            </div>

     <div class="container text-center">
             <br />
             <br />
            
             <h2>Manage Schedule</h2>
         
             <br />
             <br />
                <!-- Button trigger modal -->
            <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#exampleModal">
              Upload New Image
            </button>
         <asp:Label ID="Label1" runat="server" Visible="false"></asp:Label>

           


     
    <div class="row rounded mt-2 ">
        <asp:GridView ID="GridView1" CssClass="table table-bordered border-dark" runat="server" AutoGenerateColumns="False"  DataKeyNames="id" OnRowDataBound="GridView1_RowDataBound"
             OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" />
            <asp:BoundField DataField="ImageName" HeaderText="Name" />
            <asp:BoundField DataField="ImageType" HeaderText="Type" />
            <asp:TemplateField HeaderText="Image">
                <ItemTemplate>
                    
                    <asp:Image ID="Image1" runat="server" CssClass="w-100 p-3" ImageUrl='<%#"data:Image/png;base64," + Convert.ToBase64String((byte[])Eval("ImageData")) %>' /> 

                </ItemTemplate>
                <EditItemTemplate>
                       <asp:FileUpload ID="fileUploadEdit" runat="server" />
                    </EditItemTemplate>
            </asp:TemplateField>
            
         <asp:CommandField ShowEditButton="True" ButtonType="Button">
                     <ControlStyle CssClass="btn btn-success btn-sm"></ControlStyle></asp:CommandField>
        <asp:CommandField ShowDeleteButton="True" ButtonType="Button">
                 <ControlStyle CssClass="btn btn-danger btn-sm"></ControlStyle></asp:CommandField>
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
