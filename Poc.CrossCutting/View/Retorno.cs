using System;
using System.Net;

namespace Poc.CrossCutting.View
{
    public class Retorno<T>
    {

        public T Objeto { get; set; }
        public string Mensagem { get; set; }
        public HttpStatusCode Codigo { get; set; }
    }
}
