using DevExpress.XtraReports.Services;
using DevExpress.XtraReports.UI;
using Volo.Abp;

namespace Acme.BookStore.Report.Blazor.Client.Reports
{
    public class ReportProvider : IReportProvider
    {
        XtraReport IReportProvider.GetReport(string id, ReportProviderContext context)
        {
            if (ReportFactory.Reports.ContainsKey(id))
            {
                return ReportFactory.Reports[id]();
            }
            else
                throw new UserFriendlyException($"Could not find report '{id}'.");
        }
    }
}
