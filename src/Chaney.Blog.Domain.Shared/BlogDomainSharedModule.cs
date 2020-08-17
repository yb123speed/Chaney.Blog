using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Chaney.Blog
{
    [DependsOn(
        typeof(AbpIdentityDomainSharedModule)
        )]
    public class BlogDomainSharedModule : AbpModule
    {
    }
}
