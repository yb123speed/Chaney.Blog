﻿using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Chaney.Blog
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule),
        typeof(BlogApplicationModule)
        )]
    public class BlogHttpApiModule : AbpModule
    {
        
    }
}
