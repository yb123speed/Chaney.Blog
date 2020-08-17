using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.MultiTenancy;

namespace Chaney.Blog
{
    [DependsOn(
        typeof(AbpIdentityDomainModule)
        )]
    public class BlogDomainModule : AbpModule
    {

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            base.ConfigureServices(context);
        }
    }
}
