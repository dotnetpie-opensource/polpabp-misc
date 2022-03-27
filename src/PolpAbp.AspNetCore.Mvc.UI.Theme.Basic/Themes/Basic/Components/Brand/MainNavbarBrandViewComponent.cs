using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.Brand
{
    public class MainNavbarBrandViewComponent : AbpViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Themes/Basic/Components/Brand/Default.cshtml");
        }
    }
}
