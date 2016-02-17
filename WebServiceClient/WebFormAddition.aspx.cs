using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebServiceClient.ServiceReference1;

namespace WebServiceClient
{
    public partial class WebFormAddition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnClick(object sender, EventArgs e)
        {
            var a = Convert.ToDouble(textBox1.Text);
            var b = Convert.ToDouble(textBox2.Text);

            var client = new TextWebServiceSoapClient();
            label1.Text = client.Addition(a, b).ToString();
        }
    }
}