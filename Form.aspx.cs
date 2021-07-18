using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace WebApp
{
    public partial class Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {

            string csvPath = Server.MapPath("~/csvfiles/") + Path.GetFileName(FileUpload.PostedFile.FileName);
            FileUpload.SaveAs(csvPath);

  
            DataTable dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[6] {
        new DataColumn("Student Number", typeof(string)),
        new DataColumn("Full Name", typeof(string)),
        new DataColumn("Surname", typeof(string)),
        new DataColumn("Course Code",typeof(string)),
        new DataColumn("Course Description", typeof(string)),
        new DataColumn("Grade", typeof(string))});


            string csvData = File.ReadAllText(csvPath);

 
            foreach (string row in csvData.Split('\n'))
            {
                if (!string.IsNullOrEmpty(row))
                {
                    dt.Rows.Add();
                    int i = 0;

           
                    foreach (string cell in row.Split(','))
                    {
                        dt.Rows[dt.Rows.Count - 1][i] = cell;
                        i++;
                    }
                }
            }

            GridView.DataSource = dt;
            GridView.DataBind();
        }
    }
}
      
