﻿using Microsoft.Extensions.DependencyInjection;
using PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander.Bundling;
using PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander.Toolbars;
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

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcUiThemeSharedModule),
        typeof(AbpAspNetCoreMvcUiMultiTenancyModule)
        )]
    public class PolpAbpAspNetCoreMvcUIBootslanderThemeModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(PolpAbpAspNetCoreMvcUIBootslanderThemeModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpThemingOptions>(options =>
            {
                options.Themes.Add<BootslanderTheme>();

                if (options.DefaultThemeName == null)
                {
                    options.DefaultThemeName = BootslanderTheme.Name;
                }
            });

            Configure<AbpToolbarOptions>(options =>
            {
                options.Contributors.Add(new BootslanderThemeMainTopToolbarContributor());
            });

            Configure<AbpBundlingOptions>(options =>
            {
                options
                    .StyleBundles
                    .Add(BootslanderThemeBundles.Styles.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Styles.Global)
                            .AddContributors(typeof(BootslanderThemeGlobalStyleContributor));
                    });

                options
                    .ScriptBundles
                    .Add(BootslanderThemeBundles.Scripts.Global, bundle =>
                    {
                        bundle
                            .AddBaseBundles(StandardBundles.Scripts.Global)
                            .AddContributors(typeof(BootslanderThemeGlobalScriptContributor));
                    });
            });
        }
    }
}
