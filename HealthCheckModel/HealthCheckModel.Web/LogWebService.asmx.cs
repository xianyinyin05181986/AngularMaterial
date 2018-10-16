using HealthCheckModel.Module.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace HealthCheckModel.Web
{
    /// <summary>
    /// Summary description for LogWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class LogWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetLogInformation()
        {
            return HealthModelViewController.LongOperationStatus;
        }

        [WebMethod]
        public string GetOtherInformation()
        {
            return "Kartik";
        }

        [WebMethod()]
        public string GetLogInformation2(string p)
        {
            return String.Format("Hello,{0}",p);
        }
    }
}
