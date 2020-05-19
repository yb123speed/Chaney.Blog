using Volo.Abp.Modularity;

namespace Chaney.Blog
{
    [DependsOn(
        typeof(BlogApplicationModule),
        typeof(BlogDomainTestModule)
        )]
    public class BlogApplicationTestModule : AbpModule
    {

    }
}