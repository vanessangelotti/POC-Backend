using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Poc.API.View;
using Poc.CrossCutting.View;

namespace Poc.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        [HttpGet]
        [Route("obter-lista")]
        public IActionResult Get()
        {
            List<Contato> contatos = new List<Contato>();
            var retorno = new Retorno<List<Contato>>();

            try
            {
                contatos.Add(new Contato { id = 1, nome = "Vanessa Angelotti", email = "vanessangelotti@hotmail.com" });
                contatos.Add(new Contato { id = 2, nome = "Valeria Angelotti", email = "valeriangelotti@yoopmail.com" });

            }
            catch (Exception)
            {
                retorno.Codigo = HttpStatusCode.BadRequest;
            }

            return Ok(contatos);
        }

        [HttpGet]
        [Route("obter-nome")]
        public IActionResult GetName()
        {
            return Ok("Vanessa Angelotti");
        }


    }
}
