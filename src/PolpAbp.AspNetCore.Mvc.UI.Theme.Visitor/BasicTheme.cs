using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace PolpAbp.AspNetCore.Mvc.UI
{
    [ThemeName(Name)]
    public class VisitorTheme : ITheme, ITransientDependency
    {
        public const string Name = "Basic";

        public virtual string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case StandardLayouts.Application:
                    return "~/Themes/Visitor/Layouts/Application.cshtml";
                case StandardLayouts.Account:
                    return "~/Themes/Visitor/Layouts/Account.cshtml";
                case StandardLayouts.Empty:
                    return "~/Themes/Visitor/Layouts/Empty.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/Visitor/Layouts/Application.cshtml" : null;
            }
        }
    }
}
