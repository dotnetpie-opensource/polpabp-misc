using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PolpAbp.AspNetCore.Mvc.UI.Themes.Basic.Components.PolicyConsent;

public class PolicyConsentViewComponent : ViewComponent
{
    public virtual Task<IViewComponentResult> InvokeAsync()
    {
        IViewComponentResult ret = View("~/Themes/Basic/Components/PolicyConsent/Default.cshtml");
        return Task.FromResult(ret);
    }
}
