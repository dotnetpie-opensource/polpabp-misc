﻿using Volo.Abp.AspNetCore.Mvc.UI.Bundling;
using Volo.Abp.Localization;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander.Bundling
{
    public class BootslanderThemeGlobalStyleContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {

            if (CultureHelper.IsRtl)
            {
                context.Files.Add("/custom/bootstrap5/css/bootstrap.rtl.css");
            }
            else
            {
                context.Files.Add("/custom/bootstrap5/css/bootstrap.css");
            }

            context.Files.Add("/libs/animate-css/animate.css");
            // todo: Maybe remove this
            context.Files.Add("/libs/bootstrap-icons/font/bootstrap-icons.css");

            context.Files.Add("/libs/line-awesome/line-awesome/css/line-awesome.css");

            context.Files.Add("/libs/magnific-popup-js/magnific-popup.css");
            context.Files.Add("/libs/owl-carousel/assets/owl.carousel.css");
            context.Files.Add("/libs/lightslider/css/lightslider.css");
            context.Files.Add("/libs/glightbox/css/glightbox.css");
            // Slider
            context.Files.Add("/libs/swiper/swiper-bundle.css");
            // Theme-specific 
            context.Files.Add("/themes/bootslander/spacing.css");

            if (CultureHelper.IsRtl)
            {
                context.Files.Add("/custom/bootslander/css/theme.rtl.css");
            }
            else
            {
                context.Files.Add("/custom/bootslander/css/theme.css");
            }
        }
    }
}
