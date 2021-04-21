using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Azure.Identity;

namespace EQM_GQE.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder
                        // Using Azure Identity
                        .ConfigureAppConfiguration((hostingContext, config) =>
                        {
                            var settings = config.Build();
                            config.AddAzureAppConfiguration(options =>
                                {
                                    options.Connect(settings["ConnectionStrings:AppConfig"])
                                        .ConfigureKeyVault(kv =>
                                        {
                                            kv.SetCredential(new DefaultAzureCredential());
                                        });
                                });
                        })
                        .UseStartup<Startup>();
                });
    }
}
