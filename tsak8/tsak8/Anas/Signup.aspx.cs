using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tsak8.Anas
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            string fname = Fname1.Text;
            string lname = Lname1.Text;
            string email = Email1.Text;
            string password = password1.Text;
            string phone = phone1.Text;
            string gender = gender1.Text;

            string data=Server.MapPath("users.txt");
            if (!File.Exists(data))
            {
                using (StreamWriter sw = File.CreateText(data))
                {
                    sw.WriteLine($"{fname},{lname},{email},{password},{phone},{gender}");
                }
                
            }
            else
            {
                using (StreamWriter sw1 = new StreamWriter(data, true))

                {
                    sw1.WriteLine($"{fname},{lname},{email},{password},{phone},{gender}");

                }
                Response.Redirect("Login.aspx");
            }
        }
    }
}