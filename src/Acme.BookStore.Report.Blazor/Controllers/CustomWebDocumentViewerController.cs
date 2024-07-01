using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Report.Blazor.Controllers
{
    // This controller is required for the Document Viewer and Report Designer.
    //[Route("api/custom-webDocument-viewer", Name = "CustomWebDocumentViewer")]
    [IgnoreAntiforgeryToken]
    public class CustomWebDocumentViewerController : WebDocumentViewerController
    {
        public CustomWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService) : base(controllerService)
        {
        }
    }




}
