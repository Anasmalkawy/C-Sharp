using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

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
                    string data = Server.MapPath("userss.txt");
                    if (!File.Exists(data))
                    {
                        using (StreamWriter sw = File.CreateText(data))
                        {
                            sw.WriteLine($"{info[0]},{info[1]},{info[2]},{info[3]},{info[4]},{info[5]}");
                        }

                    }
                    else
                    {
                        using (StreamWriter sw1 = new StreamWriter(data))

                        {
                            sw1.WriteLine($"{info[0]},{info[1]},{info[2]},{info[3]},{info[4]},{info[5]}");


                        }
                    }


                    Response.Redirect("Profile.aspx");

                    return;
                }
               
            }


            
        }
    }
}