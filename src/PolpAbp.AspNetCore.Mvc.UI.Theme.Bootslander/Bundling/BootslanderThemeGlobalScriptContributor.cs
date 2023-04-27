using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander.Bundling
{
    public class BootslanderThemeGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.Add("/libs/jquery/jquery.js");
            context.Files.Add("/libs/bootstrap/js/bootstrap.bundle.js");
            context.Files.Add("/libs/lodash/lodash.min.js");
            context.Files.Add("/libs/purecounterjs/dist/purecounter_vanilla.js");
            context.Files.Add("/libs/glightbox/js/glightbox.js");
            context.Files.Add("/libs/aos/aos.js");
            context.Files.Add("/libs/swiper/swiper-bundle.js");

            context.Files.Add("/themes/bootslander/layout.js");
        }
    }
}