using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander.Bundling
{
    public class BootslanderThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/libs/aos/aos.css");

            if (CultureHelper.IsRtl)
            {
                context.Files.Add("/libs/bootstrap/css/bootstrap.rtl.css");
            }
            else
            {
                context.Files.Add("/libs/bootstrap/css/bootstrap.css");
            }

            context.Files.Add("/libs/bootstrap-icons/font/bootstrap-icons.css");
            context.Files.Add("/libs/boxicons/css/boxicons.css");
            context.Files.Add("/libs/glightbox/css/glightbox.css");
            context.Files.Add("/libs/remixicon/remixicon.css");
            context.Files.Add("/libs/swiper/swiper-bundle.css");

            context.Files.Add("/themes/bootslander/layout.css");
        }
    }
}
