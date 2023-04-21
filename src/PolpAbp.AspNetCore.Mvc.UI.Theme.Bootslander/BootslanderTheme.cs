using Volo.Abp.AspNetCore.Mvc.UI.Theming;
using Volo.Abp.DependencyInjection;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Bootslander
{
    [ThemeName(Name)]
    public class BootslanderTheme : ITheme, ITransientDependency
    {
        public const string Name = "Bootslander";

        public virtual string GetLayout(string name, bool fallbackToDefault = true)
        {
            switch (name)
            {
                case StandardLayouts.Empty:
                    return "~/Themes/Bootslander/Layouts/Empty.cshtml";
                default:
                    return fallbackToDefault ? "~/Themes/Bootslander/Layouts/Empty.cshtml" : null;
            }
        }
    }
}
