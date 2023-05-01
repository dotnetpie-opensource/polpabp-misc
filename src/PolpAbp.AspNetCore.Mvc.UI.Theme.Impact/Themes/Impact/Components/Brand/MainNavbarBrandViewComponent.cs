using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Impact.Themes.Impact.Components.Brand;

public class MainNavbarBrandViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Impact/Components/Brand/Default.cshtml");
    }
}
