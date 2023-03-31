using ConsoleToWebAPI.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleToWebAPI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<Custom_Middleware>();

            //services.AddSingleton<IProductRepository,ProductRepository>();//this will not execute
            //services.AddSingleton<IProductRepository, TestRepository>();// this will execute-----
            //// if we chanege the order then it will not execute but productrepository will be execute

            
            services.TryAddSingleton<IProductRepository, TestRepository>(); 
            services.TryAddSingleton<IProductRepository, ProductRepository>();
        }

        public void Configure(IApplicationBuilder app,IWebHostEnvironment env)
        {
            //here we written all of our middleware
            // also we can nat change the name of method i.e. Configure


            //app.Use(async(context, next) =>
            //{
            //    await context.Response.WriteAsync("Helloo from use1-1\n");
            //    await next();
            //    await context.Response.WriteAsync("Helloo from use1-2\n");
            //});
            //app.UseMiddleware<Custom_Middleware>();//custom middleware
            //app.Map("/amit", content);

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Helloo from use2-1\n");
            //    await next();
            //    await context.Response.WriteAsync("Helloo from use2-2\n");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Helloo Request complete\n");
                
            //});


            //app.Run(async context =>  
            //{
            //    await context.Response.WriteAsync("Helloo from run2\n");
            //});


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                
            });

        }

        //private void  content(IApplicationBuilder app)
        //{
        //    app.Use(async(context, next)=>
        //    {
        //        await context.Response.WriteAsync("Helloo from amit\n");
        //    });
            
        //}
    }
}
