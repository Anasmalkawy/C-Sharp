using System;
using System.IO;
using System.Linq;
using System.Web.UI;

namespace task7new
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            string name = bookname.Text;
            string type = booktype.Text;
            string id = bookid.Text; 
            string level = booklevel.Text;

            string path = Server.MapPath("book.txt");

   
                string[] bookDetails = File.ReadAllLines(path);

 
                for (int i = 0; i < bookDetails.Length; i++)
                {
                    string[] parts = bookDetails[i].Split(',');

                    if (parts[0] == id)
                    {
                        bookDetails[i] = $"{id}, {name}, {type}, {level}";
                        File.WriteAllLines(path, bookDetails);
                        return;
                    }
                }


        }

    }
}