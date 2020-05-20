﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Chaney.Blog.HttpApi.Hosting
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<BlogHttpApiHostingModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
