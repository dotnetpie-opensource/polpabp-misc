using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace PolpAbp.AspNetCore.Mvc.UI.Themes.Basic.Components.AccountTenancy
{
    public class AccountTenancyViewComponent : AbpViewComponent
    {
        public virtual IViewComponentResult Invoke(bool showResetBtn = false)
        {
            return View("~/Themes/Basic/Components/AccountTenancy/Default.cshtml", new Model
            {
                ShowResetButton = showResetBtn
            });
        }
    }
}
