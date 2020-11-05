using System.Net;
using Microsoft.AspNetCore.Mvc;
using Poc.API.View;
using Poc.CrossCutting.View;
using Poc.Impressao.Interfaces;

namespace Poc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExemploController : ControllerBase
    {
        
        public readonly IPDF _Ipdf;

        public ExemploController(IPDF Ipdf)
        {
            _Ipdf = Ipdf;
        }


        [HttpPost]
        [Route("ConverterPDF")]
        public Retorno<byte[]> ConverterPDF (RequisicaoPDF requisicao)
        {
            var templateHtml = System.IO.File.ReadAllText(@".\Html\Template.html");

            var file = _Ipdf.ConverterLinkToPdf(templateHtml, requisicao.Parametros);

            return new Retorno<byte[]> { Objeto = file , Codigo = HttpStatusCode.OK};


        }

        [HttpPost]
        [Route("ConverterDynamicToPDF")]
        public Retorno<byte[]> ConverterDynamicToPDF(RequisicaoPDF requisicao)
        {
            var templateHtml = System.IO.File.ReadAllText(@".\Html\Template.html");

            var file = _Ipdf.ConverterDynymicPdf(templateHtml, requisicao.Parametros);

            return new Retorno<byte[]> { Objeto = file, Codigo = HttpStatusCode.OK };

        }



    }
}