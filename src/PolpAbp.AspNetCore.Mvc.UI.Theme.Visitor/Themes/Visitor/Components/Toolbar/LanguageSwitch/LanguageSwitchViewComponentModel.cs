using System.Collections.Generic;
using Volo.Abp.Localization;

namespace PolpAbp.AspNetCore.Mvc.UI.Themes.Visitor.Components.Toolbar.LanguageSwitch;

public class LanguageSwitchViewComponentModel
{
    public LanguageInfo CurrentLanguage { get; set; }

    public List<LanguageInfo> OtherLanguages { get; set; }
}
