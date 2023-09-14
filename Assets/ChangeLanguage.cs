using UnityEngine;
using UnityEngine.Localization.Settings;
public class ChangeLanguage : MonoBehaviour
{
    public void LocaleSelected(int index)
    {
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }
}