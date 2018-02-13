using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;
using System.Threading.Tasks;

namespace HtmlToPdf.Controller
{
    [EnableCors("CorsPolicy")]
    public class HtmlToPdfController : ControllerBase
    {
        [HttpGet]
        [Route("api/knock")]
        public string Knock()
        {
            return "i got it";
        }

        [HttpGet]
        [Route("/api/getnodepdf")]
        public async Task<byte[]> ExportPdf([FromServices] INodeServices nodeServices)
        {
            //http://neil.red/coding/export-html-to-pdf-in-dot-net-core/

            return await nodeServices.InvokeAsync<byte[]>("./pdf", "This is a test PDF o-[.__.]-o");
        }
    }
}