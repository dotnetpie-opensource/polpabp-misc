using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Themes.Visitor.Components.MainNavbar;

public class MainNavbarViewComponent : AbpViewComponent
{
    public virtual IViewComponentResult Invoke(bool isLight = false)
    {
        var data = new ViewModel
        {
            IsLightBackground = isLight
        };

        return View("~/Themes/Visitor/Components/MainNavbar/Default.cshtml", data);
    }

    public class ViewModel
    {
        public bool IsLightBackground { get; set; }
    }
}
