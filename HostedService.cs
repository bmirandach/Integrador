using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador
{
  internal class HostedService : IHostedService
  {
    public async Task StartAsync(CancellationToken cancellationToken)
    {
      //como no voy a poner nada en StopAsync no agrego el ReadLine
      Console.WriteLine("Work in Progress");
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
      throw new NotImplementedException();
    }
  }
}
