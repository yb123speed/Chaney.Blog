using Chaney.Blog.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Chaney.Blog
{
    [DependsOn(
        typeof(BlogEntityFrameworkCoreTestModule)
        )]
    public class BlogDomainTestModule : AbpModule
    {

    }
}