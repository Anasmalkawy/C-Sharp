using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tsak8.Anas
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            string path = Server.MapPath("users.txt");
            string[] datausers = File.ReadAllLines(path);
            for (int i = 0; i < datausers.Length; i++)
            {
                string[] user = datausers[i].Split(',');
                if (user[2] == searchbye.Text)
                {
                    datausers[i] = $"{fname1.Text},{lname1.Text},{email1.Text},{password1.Text},{phone1.Text},{gender1.Text}";
                    File.WriteAllLines(path, datausers);
                    return;
                }
            }

        }

        protected void Search_Click1(object sender, EventArgs e)
        {
            string emailll = searchbye.Text;

            string path = Server.MapPath("users.txt");
            string[] datausers=File.ReadAllLines(path);

            foreach (var line in datausers)
            {
                string[] user = line.Split(',');
                if (user[2]==emailll) 
                {
                    fname1.Text = user[0];
                    lname1.Text = user[1];
                    email1.Text = user[2];
                    password1.Text = user[3];
                    phone1.Text = user[4];
                    gender1.Text = user[5];

                }
            }
        }
    }
}