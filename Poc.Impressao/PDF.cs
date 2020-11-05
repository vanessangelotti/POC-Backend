using DinkToPdf;
using DinkToPdf.Contracts;
using Poc.Impressao.Entidades;
using Poc.Impressao.Interfaces;
using System;
using System.Collections.Generic;
using ceTe.DynamicPDF.HtmlConverter;

namespace Poc.Impressao
{
    public class PDF : IPDF
    {
        private readonly IConverter _conversor;
        public PDF(IConverter conversor)
        {
            _conversor = conversor;
        }

        public byte[] ConverterLinkToPdf(string html, List<Parametro> parametros)
        {

            html = SubstituirParametro(html, parametros);

            return Converter(html, ColorMode.Color, Orientation.Portrait, PaperKind.A4);
        }

        public byte[] ConverterDynymicPdf(string html, List<Parametro> parametros)
        {
            html = SubstituirParametro(html, parametros);

            return ceTe.DynamicPDF.HtmlConverter.Converter.Convert(html, null, null);

        }


        private string SubstituirParametro(string html, List<Parametro> parametros)
        {
            foreach (var item in parametros)
            {
                html = html.Replace(item.Nome, item.Valor);

            }

            return html;

        }

        private byte[] Converter(string html, ColorMode cor, Orientation orientacao, PaperKind tipoPapel)
        {

            var doc = new HtmlToPdfDocument()
            {
                GlobalSettings = {
                ColorMode = cor,
                Orientation = orientacao,
                PaperSize = tipoPapel,
            },
                Objects = {
                    new ObjectSettings() {
                        PagesCount = true,
                        HtmlContent = html,
                        WebSettings = { DefaultEncoding = "utf-8" },
                        HeaderSettings = { FontSize = 9, Right = "Page [page] of [toPage]", Line = true, Spacing = 2.812 }
                    }
                }
            };

            return _conversor.Convert(doc);
        }

    }
}
