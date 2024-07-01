using DevExpress.AspNetCore.Reporting.QueryBuilder;
using DevExpress.AspNetCore.Reporting.QueryBuilder.Native.Services;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Report.Blazor.Controllers
{
    // This controller is required for the Report Designer.
    //[Route("api/custom-query-builder", Name = "CustomQueryBuilder")]
    [IgnoreAntiforgeryToken]
    public class CustomQueryBuilderController : QueryBuilderController
    {
        public CustomQueryBuilderController(IQueryBuilderMvcControllerService controllerService) : base(controllerService)
        {
        }
    }
}
