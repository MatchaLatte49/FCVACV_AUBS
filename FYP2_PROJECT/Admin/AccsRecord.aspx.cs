using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace FYP2_PROJECT.Admin
{
    public partial class AccsRecord : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userEmail"] == null)
            {
                Response.Redirect("/default.aspx");
            }
            else
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();

            }
            if (!IsPostBack)
            {
                GVBind();
            }
        }

        protected void GVBind()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strcon))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM RequestsAccs WHERE Status = 'RECORDED'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        GridView1.DataSource = dr;
                        GridView1.DataBind();
                        Label1.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "An error occurred while retrieving the data from the database.";
                errorMessage += "\nError Message:" + ex.Message;
                ClientScript.RegisterStartupScript(GetType(), "Error", "alert('" + errorMessage + "');", true);
            }
        }

        protected void ExportToPDF_Click(object sender, EventArgs e)
        {
            // Create a new PDF document
            Document document = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 0f);
            PdfWriter.GetInstance(document, Response.OutputStream);

            // Open the document
            document.Open();

            // Add the title to the document
            Paragraph title = new Paragraph("Used Accessories Record");
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            // add spacing between title and table gridview
            Paragraph blankPara = new Paragraph();
            blankPara.SpacingBefore = 20f;
            document.Add(blankPara);

            // Create a new font for the table cells
            Font font = new Font(Font.FontFamily.TIMES_ROMAN, 9f);

            // Create a new table with the same number of columns as the GridView
            PdfPTable table = new PdfPTable(GridView1.Columns.Count);

            // Add the GridView headers to the table
            for (int i = 0; i < GridView1.Columns.Count; i++)
            {
                table.AddCell(new Phrase(GridView1.Columns[i].HeaderText, font));
            }

            // Add the GridView data to the table
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                for (int j = 0; j < GridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(GridView1.Rows[i].Cells[j].Text, font));
                }
            }

            // Add the table to the document
            document.Add(table);

            // Close the document
            document.Close();

            // Set the content type and file name for the response
            Response.ContentType = "application/pdf";
            Response.AddHeader("content-disposition", "attachment;filename=AccessoriesRecord.pdf");

            // Write the response to the output stream
            Response.Write(document);
            Response.Flush();
            Response.End();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            //check if the row is the header row
            if (e.Row.RowType == DataControlRowType.Header)
            {
                //add the thead and tbody section programatically
                e.Row.TableSection = TableRowSection.TableHeader;
            }
        }
    }
}