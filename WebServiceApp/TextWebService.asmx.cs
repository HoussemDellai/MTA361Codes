using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceApp
{
    /// <summary>
    /// Summary description for TextWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TextWebService : WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string ToUpper(string inputString)
        {
            return inputString.ToUpper();
        }

        [WebMethod]
        public string ToLower(string inputString)
        {
            return inputString.ToLower();
        }

        [WebMethod]
        public double Addition(double a, double b)
        {
            return a + b;
        }
    }
}
