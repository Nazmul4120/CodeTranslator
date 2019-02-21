using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button1_Click(object sender, EventArgs e)
    {
        if((email.Text=="Streame" && pwd.Text == "123")||(email.Text== "marouf.cse@diu.edu.bd") && (pwd.Text=="123"))
        {
            Response.Redirect("Developer.aspx");
        }
    }
}