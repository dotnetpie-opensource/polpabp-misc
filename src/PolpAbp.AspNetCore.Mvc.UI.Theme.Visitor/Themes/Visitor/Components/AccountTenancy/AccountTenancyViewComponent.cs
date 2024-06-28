using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Themes.Basic.Components.AccountTenancy
{
    public class AccountTenancyViewComponent : AbpViewComponent
    {
        public virtual IViewComponentResult Invoke(bool showResetBtn = false, bool hidden = false)
        {
            return View("~/Themes/Visitor/Components/AccountTenancy/Default.cshtml", new Model
            {
                Hidden= hidden,
                ShowResetButton = showResetBtn
            });
        }
    }
}
