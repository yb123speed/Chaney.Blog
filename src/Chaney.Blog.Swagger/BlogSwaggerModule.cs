using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Chaney.Blog.Swagger;
using Volo.Abp;
using Microsoft.AspNetCore.Builder;

namespace Chaney.Blog
{
    [DependsOn(
        typeof(BlogDomainModule)
        )]
    public class BlogSwaggerModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddSwagger();
            base.ConfigureServices(context);
        }

        public override void OnApplicationInitialization(ApplicationInitializationContext context)
        {
            context.GetApplicationBuilder().UseSwagger().UseSwaggerUI();
            base.OnApplicationInitialization(context);
        }
    }
}
