using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MVC_Michael.Data;
using Microsoft.Extensions.DependencyInjection;

namespace MVC_Michael
{
  public class Program
  {
    public static void Main(string[] args)
    {
      var host = BuildWebHost(args);
      RunSeeding(host);
      host.Run();
    }

    private static void RunSeeding(IWebHost host)
    {
      var scopeFactory = host.Services.GetService<IServiceScopeFactory>();
      using (var scope = scopeFactory.CreateScope())
      {
      var seeder = scope.ServiceProvider.GetService<ParkListSeeder>();
      seeder.Seed(); 
      }
      

    }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
              .ConfigureAppConfiguration(SetupConfiguration)
              .UseStartup<Startup>()
              .Build();

    private static void SetupConfiguration(WebHostBuilderContext ctx, IConfigurationBuilder builder)
    {
      builder.Sources.Clear();

      builder.AddJsonFile("config.json", false, true);
    }
  }
}
