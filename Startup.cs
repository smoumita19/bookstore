using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstConsoleApp
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //All the dependencies which are used in the application
            services.AddControllersWithViews();

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //HTTP Application

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                /*endpoints.MapGet("/", async context =>
                {
                    if (env.IsDevelopment())
                    {
                        await context.Response.WriteAsync("Hello from dev");
                    }
                    else if (env.IsProduction())
                    {
                        await context.Response.WriteAsync("Hello from prod");
                    }
                    else if (env.IsStaging())
                    {
                        await context.Response.WriteAsync("Hello from stag");
                    }
                    else
                        await context.Response.WriteAsync(env.EnvironmentName);

                });*/

                //Default route to the home controller
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
