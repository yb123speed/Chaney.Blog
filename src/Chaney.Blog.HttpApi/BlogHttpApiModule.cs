using Volo.Abp.Identity;
using Volo.Abp.Modularity;

namespace Chaney.Blog
{
    [DependsOn(
        typeof(AbpIdentityHttpApiModule)
        )]
    public class BlogHttpApiModule : AbpModule
    {
        
    }
}
