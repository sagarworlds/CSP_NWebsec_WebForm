using Newtonsoft.Json;
using NWebsec.Csp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace CSPReporting
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }
        protected void Application_PreSendRequestHeaders()
        {
            //if (HttpContext.Current != null)
            //{
            //    HttpContext.Current.Response.Headers.Remove("Server");
            //}
        }
        protected void NWebSecHttpHeaderSecurityModule_CspViolationReported(object sender, CspViolationReportEventArgs e)
        {
            var report = e.ViolationReport;
            var serializedReport = JsonConvert.SerializeObject(report.Details);
            //new ReportCspViolation().SaveReport(serializedReport);
        }

    }
}