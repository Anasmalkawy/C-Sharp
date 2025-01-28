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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filepath = Server.MapPath("meting.txt");

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
    }
}