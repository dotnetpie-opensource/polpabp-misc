using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace PolpAbp.AspNetCore.Mvc.UI.Bundling
{
    public class VisitorThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.RemoveAll(x => x.FileName.Contains("bootstrap.css") || x.FileName.Contains("bootstrap.rtl.css"));

            if (CultureHelper.IsRtl)
            {
                context.Files.Add("/custom/bootstrap5/css/bootstrap.rtl.css");
                context.Files.Add("/themes/visitor/layout.rtl.css");
            }
            else
            {
                context.Files.Add("/custom/bootstrap5/css/bootstrap.css");
                context.Files.Add("/themes/visitor/layout.css");
            }
        }
    }
}
