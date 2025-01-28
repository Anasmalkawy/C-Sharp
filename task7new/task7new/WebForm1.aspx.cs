using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task7new
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn2_Click(object sender, EventArgs e)
        {

            string username = text1.Text;
            string password = text2.Text;


            string filepath = Server.MapPath("anas.txt");

            string[] usersdata = File.ReadAllLines(filepath);
            foreach (var user in usersdata)
            {
                string[] userdata = user.Split(',');
                if (username=="admin" && password=="123")
                {
                    Response.Redirect("WebForm7.aspx");

                }
                if (userdata[0] == username && userdata[2]==password)
                {
                    Response.Redirect("WebForm4.aspx");
                }
            }


        }
    }
}