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

            string name = bookname.Text; // New book name
            string type = booktype.Text; // New book type
            string id = bookid.Text;     // ID to update
            string level = booklevel.Text; // New book level

            string path = Server.MapPath("book.txt");

            if (File.Exists(path))
            {
                // Read all lines from the file into a List
                var bookDetails = File.ReadAllLines(path).ToList();

                // Flag to track if a match was found
                bool matchFound = false;

                // Iterate and update the line with the matching ID
                for (int i = 0; i < bookDetails.Count; i++)
                {
                    var parts = bookDetails[i].Split(',');

                    // Ensure we trim whitespace for accurate comparison
                    if (parts[0].Trim() == id)
                    {
                        bookDetails[i] = $"{id}, {name}, {type}, {level}";
                        matchFound = true;
                        File.WriteAllLines(path, bookDetails);
                        return;
                    }
                }


            }
        }

    }
}