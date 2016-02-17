using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebFormSession : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Name"] != null)
                Response.Redirect("WebForm2.aspx");
        }
        protected void Button1_OnClick(object sender, EventArgs e)
        {
            Session.Add("Name", TextBox1.Text);
            //Session.Remove("Name");
            Response.Redirect("WebForm2.aspx");
        }
    }
}