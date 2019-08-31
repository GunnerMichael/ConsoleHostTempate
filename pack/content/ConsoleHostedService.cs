using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleExample
{
    public class ConsoleHostedService : IHostedService
    {
        private readonly IServiceScopeFactory _serviceFactory;

        public ConsoleHostedService(
            IServiceScopeFactory serviceFactory
            )   
        {
            _serviceFactory = serviceFactory;            
        }
        public Task StartAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
