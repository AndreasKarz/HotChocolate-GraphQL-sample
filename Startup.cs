using HotChocolate;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Subscriptions;
using HotChocolate.Stitching;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LearnHotChocolate
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQLSubscriptions();

            services.AddHttpClient("countryService", client =>
                client.BaseAddress = new System.Uri("http://countries.trevorblades.com/"));

            services.AddStitchedSchema(builder => builder.AddSchemaFromHttp("countryService"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphQL();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("<a href=\"https://chillicream.com/blog/2019/09/27/strawberry-shake\" target=\"_blank\">Doku</a><br /><a href=\"https://www.youtube.com/watch?v=Lr6qyoAT8k4\" target =\"_blank\">YouTube</a>");
            });
        }
    }
}
