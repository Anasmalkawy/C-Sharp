using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task7new
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            string username = text1.Text;
            string Email = text2.Text;
            string Password= text3.Text;
            string Rpassword = text4.Text;

            string filepath = Server.MapPath("anas.txt");


            string userdata = $"{username},{Email},{Password},{Rpassword}";

            using (StreamWriter sw = new StreamWriter(filepath ,true))
            {
                sw.WriteLine(userdata);
            }

            Response.Redirect("WebForm1.aspx");


        }
    }
}