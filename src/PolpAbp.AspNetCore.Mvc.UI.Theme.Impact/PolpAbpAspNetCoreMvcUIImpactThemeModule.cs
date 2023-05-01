using Microsoft.Extensions.DependencyInjection;
using PolpAbp.AspNetCore.Mvc.UI.Theme.Impact.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Impact
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcUiThemeSharedModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
        )]
    public class PolpAbpAspNetCoreMvcUIImpactThemeModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(PolpAbpAspNetCoreMvcUIImpactThemeModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpThemingOptions>(options =>
            {
                options.Themes.Add<ImpactTheme>();

                if (options.DefaultThemeName == null)
                {
                    options.DefaultThemeName = ImpactTheme.Name;
                }
            });

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<PolpAbpAspNetCoreMvcUIImpactThemeModule>("PolpAbp.AspNetCore.Mvc.UI.Theme.Impact");
            });

            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .StyleBundles
                    .Add(ImpactThemeBundles.Styles.Global, bundle =>
                    {
                        bundle
                            .AddContributors(typeof(ImpactThemeGlobalStyleContributor));
                    });

                options
                    .ScriptBundles
                    .Add(ImpactThemeBundles.Scripts.Global, bundle =>
                    {
                        bundle
                            .AddContributors(typeof(ImpactThemeGlobalScriptContributor));
                    });
            });
        }
    }
}
