using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Impact
{
    [ThemeName(Name)]
    public class ImpactTheme : ITheme, ITransientDependency
    {
        public const string Name = "Impact";

        public virtual string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case StandardLayouts.Empty:
                    return "~/Themes/Impact/Layouts/Empty.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/Impact/Layouts/Empty.cshtml" : null;
            }
        }
    }
}
