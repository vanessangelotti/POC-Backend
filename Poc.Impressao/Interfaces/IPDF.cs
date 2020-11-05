using Poc.Impressao.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Poc.Impressao.Interfaces
{
    public interface IPDF
    {

        byte[] ConverterLinkToPdf(string html, List<Parametro> parametros);

        byte[] ConverterDynymicPdf(string html, List<Parametro> parametros);
    }
}
