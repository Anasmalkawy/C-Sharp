using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace task7new
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");

        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");

        }
    }
}