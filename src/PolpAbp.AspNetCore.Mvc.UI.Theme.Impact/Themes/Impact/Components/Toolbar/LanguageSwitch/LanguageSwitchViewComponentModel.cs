using System.Collections.Generic;
using Volo.Abp.Localization;

namespace PolpAbp.AspNetCore.Mvc.UI.Theme.Impact.Themes.Impact.Components.Toolbar.LanguageSwitch;

public class LanguageSwitchViewComponentModel
{
    public LanguageInfo CurrentLanguage { get; set; }

    public List<LanguageInfo> OtherLanguages { get; set; }
}
