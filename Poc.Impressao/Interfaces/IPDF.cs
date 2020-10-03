using Poc.Impressao.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.Impressao.Interfaces
{
    public interface IPDF
    {

        byte[] Converter(string html, List<Parametro> parametros);
    }
}
