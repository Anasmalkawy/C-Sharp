using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task7new
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string bookid1 = bookid.Text;
            string booktype1 = booktype.Text;
            string booklevel1 = booklevel.Text;
            string bookname1 = bookname.Text;

            string filepath = Server.MapPath("book.txt");
       

            string book = $"{bookid1},{bookname1},{booktype1},{booklevel1}";

            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                sw.WriteLine(book);
            }

            Response.Redirect("WebForm7.aspx");


        }
    }
}