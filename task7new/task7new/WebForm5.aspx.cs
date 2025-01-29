using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task7new
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("book.txt");

            string[] books = File.ReadAllLines(filepath);
            StringBuilder row = new StringBuilder();
            foreach (var user in books)
            {
                string[] book = user.Split(',');


                row.Append("<tr>");
                row.Append($"<td> {book[0]} </td> ");
                row.Append($"<td> {book[1]} </td> ");
                row.Append($"<td> {book[2]} </td> ");
                row.Append($"<td> {book[3]} </td> ");
                row.Append("</tr>");
            }
            table1.InnerHtml = row.ToString();

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            string id = abd.Text;
            string path = Server.MapPath("book.txt");

            var bookDetails = File.ReadAllLines(path).ToList();

            for (int i = 0; i < bookDetails.Count; i++)
            {
                var parts = bookDetails[i].Split(',');

                if (parts[0].Trim() == id)
                {
                    Console.WriteLine(bookDetails[i]);
                    aba.Text = bookDetails[i];
                    aba.Visible = true;
                }
            }
        }
    }
}