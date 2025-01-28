using System;
using System.IO;

namespace WebAppDemo
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            string inputText = TextBox1.Text;
            string filePath = Server.MapPath("~/Data.txt");

            // Write to file
            File.WriteAllText(filePath, inputText);

            // Read from file
            string fileContent = File.ReadAllText(filePath);

            // Display the content on the label
            LabelResult.Text = "File Content: " + fileContent;

        }

        protected void ButtonNavigate1(object sender, EventArgs e)
        {

            Response.Redirect("WebForm2.aspx");
        }
    }
}
