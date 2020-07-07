using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExampleDevExpress.Controllers
{
    public class Report01Controller : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("xxxx")]
        public IActionResult PrintReportTaxExemption()
        {
            var memoryStream = GetReport.GetReportXXXXX();
            //HttpResponseMessage result = new HttpResponseMessage(HttpStatusCode.OK);
            //result.Content = new StreamContent(memoryStream);
            //result.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
            //result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
            //{
            //    FileName = string.Format("{0}.pdf", "Filename"),
            //};

            return File(memoryStream.ToArray(), "application/octet-stream", "RegisterIPDReport.pdf");

            //return null; // ResponseMessage(result);
        }

    }
}
