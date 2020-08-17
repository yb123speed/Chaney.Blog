﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Chaney.Blog.Swagger
{
    public static class BlogSwaggerExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "1.0.0",
                    Title = "Blog Api",
                    Description = "",
                });

                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Chaney.Blog.HttpApi.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Chaney.Blog.Domain.xml"));
                options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Chaney.Blog.Application.Contracts.xml"));

            });
        }

        public static void UseSwaggerUI(this IApplicationBuilder app)
        {
            app.UseSwaggerUI(options => {
                options.SwaggerEndpoint($"/swagger/v1/swagger.json","Default API");
            });
        }
    }
}
