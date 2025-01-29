using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tsak8.Anas
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            string email = email1.Text;
            string pass = password.Text;

            string users = Server.MapPath("users.txt");

            string[] usersdata = File.ReadAllLines(users);
            foreach (string user in usersdata) 
            {
                string[] info = user.Split(',');
                if (info[2]==email && info[3]==pass)
                {
                    Response.Redirect("Profile.aspx");
                    return;
                }
               
            }
        }
    }
}