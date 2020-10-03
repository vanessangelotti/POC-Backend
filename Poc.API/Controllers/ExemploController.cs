using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poc.API.View;
using Poc.CrossCutting.IoC;
using Poc.CrossCutting.View;
using Poc.Impressao.Entidades;
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
            var templateHtml = System.IO.File.ReadAllText(@"C:\Temp\Templete.html");

            var file = _Ipdf.Converter(templateHtml, requisicao.Parametros);

            return new Retorno<byte[]> { Objeto = file , Codigo = 200};

        }

        

    }
}