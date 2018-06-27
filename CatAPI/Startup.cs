using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatAPI.Interfaces;
using CatAPI.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace CatAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .AddXmlDataContractSerializerFormatters();

            services
                .AddTransient<ICategoryService, CategoryService>();

            services
                .AddTransient<IImageService, ImageService>();

            services
               .AddTransient<IDataProviderCategory, InMemoryDataProvider>();

            services
               .AddTransient<IDataProviderImage, InMemoryDataProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
