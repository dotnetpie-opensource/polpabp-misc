using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace PolpAbp.AspNetCore.Mvc.UI.Bundling
{
    public class BasicThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            var stdOnes = context.Files.Find(x => x.FileName.Contains("bootstrap.css"));
            if (stdOnes != null)
            {
                context.Files.Remove(stdOnes);
            }

            if (CultureHelper.IsRtl)
            {
                // todo: Support RTL 
                // context.Files.Add("/custom/bootstrap5/css/bootstrap.rtl.css");
                context.Files.Add("/custom/bootstrap5/css/bootstrap.css");
            }
            else
            {
                context.Files.Add("/custom/bootstrap5/css/bootstrap.css");
            }

            context.Files.Add("/themes/basic/layout.css");
        }
    }
}
