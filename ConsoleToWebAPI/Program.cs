using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleToWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
         
        public static IHostBuilder CreateHostBuilder(string[] args) =>
        //CreateHostBuilder - We can not change this method name if we use entity framework, We can change it in simple logics.
        
             Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webHost=>
                {
                    webHost.UseStartup<Startup>();
                });
        
    }
}
