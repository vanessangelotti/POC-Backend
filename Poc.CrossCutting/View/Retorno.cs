using System;

namespace Poc.CrossCutting.View
{
    public class Retorno<T>
    {

        public T Objeto { get; set; }
        public string Mensagem { get; set; }
        public int Codigo { get; set; }
    }
}
