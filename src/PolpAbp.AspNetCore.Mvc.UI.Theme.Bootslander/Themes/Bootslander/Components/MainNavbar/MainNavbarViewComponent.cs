using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander.Themes.Bootslander.Components.MainNavbar;

public class MainNavbarViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke(bool isLight = false)
    {
        var data = new ViewModel
        {
            IsLightBackground = isLight
        };

        return View("~/Themes/Bootslander/Components/MainNavbar/Default.cshtml", data);
    }

    public class ViewModel
    {
        public bool IsLightBackground { get; set; }
    }
}
