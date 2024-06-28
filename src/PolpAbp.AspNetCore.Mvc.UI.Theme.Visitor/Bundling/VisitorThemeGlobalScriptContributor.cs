using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace PolpAbp.AspNetCore.Mvc.UI.Bundling
{
    public class VisitorThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/themes/visitor/layout.js");
        }
    }
}