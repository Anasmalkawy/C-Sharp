using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task7new
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            



        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string metingidd = m1.Text;
            string metingname = m2.Text;
            string metingtime = m3.Text;
            string metingdata  = m4.Text;

            string filepath = Server.MapPath("meting.txt");


            string book = $"{metingidd},{metingname},{metingtime},{metingdata}";

            using (StreamWriter sw = new StreamWriter(filepath, true))
            {
                sw.WriteLine(book);
            }

            Response.Redirect("WebForm7.aspx");
        }
    }
}