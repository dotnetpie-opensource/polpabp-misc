﻿using Microsoft.Extensions.DependencyInjection;
using PolpAbp.AspNetCore.Mvc.UI.Bundling;
using PolpAbp.AspNetCore.Mvc.UI.Themes.Visitor.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy;
using Volo.Abp.AspNetCore.Mvc.UI.MultiTenancy.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Bundling;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Toolbars;
using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace PolpAbp.AspNetCore.Mvc.UI
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcUiThemeSharedModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
        )]
    public class PolpAbpAspNetCoreMvcUIVisitorThemeModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(PolpAbpAspNetCoreMvcUIVisitorThemeModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpThemingOptions>(options =>
            {
                options.Themes.Add<VisitorTheme>();

                if (options.DefaultThemeName == null)
                {
                    options.DefaultThemeName = VisitorTheme.Name;
                }
            });

            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<PolpAbpAspNetCoreMvcUIVisitorThemeModule>("PolpAbp.AspNetCore.Mvc.UI");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<AbpUiMultiTenancyResource>()
                    .AddVirtualJson("/Localization/PolpAbp/Theme/Visitor/MultiTenancy");
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new VisitorThemeMainTopToolbarContributor());
            });

            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .StyleBundles
                    .Add(VisitorThemeBundles.Styles.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Styles.Global)
                            .AddContributors(typeof(VisitorThemeGlobalStyleContributor));
                    });

                options
                    .ScriptBundles
                    .Add(VisitorThemeBundles.Scripts.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Scripts.Global)
                            .AddContributors(typeof(VisitorThemeGlobalScriptContributor));
                    });
            });
        }
    }
}
