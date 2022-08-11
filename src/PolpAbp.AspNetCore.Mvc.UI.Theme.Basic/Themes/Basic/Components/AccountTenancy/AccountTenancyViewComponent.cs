using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Basic.Themes.Basic.Components.AccountTenancy
{
    public class AccountTenancyViewComponent : AbpViewComponent
    {
        public virtual IViewComponentResult Invoke()
        {
            return View("~/Themes/Basic/Components/AccountTenancy/Default.cshtml");
        }
    }
}
