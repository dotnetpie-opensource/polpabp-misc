using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Themes.Visitor.Components.Footer
{
    public partial class FooterViewComponent : AbpViewComponent
    {
        public virtual IViewComponentResult Invoke()
        {
            return View("~/Themes/Visitor/Components/Footer/Default.cshtml");
        }
    }
}
