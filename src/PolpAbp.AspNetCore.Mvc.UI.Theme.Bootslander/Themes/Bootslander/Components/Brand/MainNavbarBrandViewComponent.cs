using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander.Themes.Bootslander.Components.Brand;

public class MainNavbarBrandViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke()
    {
        return View("~/Themes/Bootslander/Components/Brand/Default.cshtml");
    }
}
