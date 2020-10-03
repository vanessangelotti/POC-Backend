using Microsoft.Extensions.DependencyInjection;
using Poc.Impressao;
using Poc.Impressao.Interfaces;
using System;

namespace Poc.CrossCutting.IoC
{
    public class InjectionContainer
    {
        public IServiceCollection ObterScopo(IServiceCollection interfaceService)
        {

            #region Impressao

                interfaceService.AddScoped(typeof(IPDF), typeof(PDF));

            #endregion

            return interfaceService;

        }

    }
}
