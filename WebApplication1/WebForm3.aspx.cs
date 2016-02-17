using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            var a = textBox1.Text;
            var b = textBox2.Text;

            var a1 = Convert.ToInt32(a);
            var b1 = Convert.ToInt32(b);

            var somme = a1 + b1;

            label1.Text = somme.ToString();
        }
    }
}