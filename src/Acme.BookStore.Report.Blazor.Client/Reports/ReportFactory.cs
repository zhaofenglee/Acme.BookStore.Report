using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System;

namespace Acme.BookStore.Report.Blazor.Client.Reports
{
    public class ReportFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["TestReport"] = () => new TestReport()
        };
    }
}
