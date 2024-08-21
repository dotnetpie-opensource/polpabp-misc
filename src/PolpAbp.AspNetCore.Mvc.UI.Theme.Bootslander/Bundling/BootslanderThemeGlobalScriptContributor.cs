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
            context.Files.Add("/libs/jquery-isotope/isotope.pkgd.js");
            context.Files.Add("/libs/owl-carousel/owl.carousel.js");
            context.Files.Add("/libs/wow/wow.js");
            context.Files.Add("/libs/jquery-countdown/jquery.countdown.js");
            context.Files.Add("/libs/magnific-popup-js/jquery.magnific-popup.js");
            context.Files.Add("/libs/simple-parallax-js/simpleParallax.js");
            context.Files.Add("/libs/lightslider/js/lightslider.js");
            context.Files.Add("/libs/glightbox/js/glightbox.js");
            context.Files.Add("/libs/swiper/swiper-bundle.js");

            // Theme-specific 
            context.Files.Add("/themes/bootslander/theme-ht-counter.js");
            context.Files.Add("/themes/bootslander/theme-ht-parallax.js");

            context.Files.Add("/themes/bootslander/theme-script.js");
        }
    }
}