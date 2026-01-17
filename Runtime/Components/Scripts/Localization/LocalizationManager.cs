using StvDEV.GDK.Patterns;
using UnityEngine;
using UnityEngine.Events;

namespace StvDEV.GDK.Components.Localization
{
    /// <summary>
    /// Data storage for a localized component.
    /// </summary>
    public interface ILocalizationData
    {
        /// <summary>
        /// Language identifier.
        /// </summary>
        public string Language { get; }
    }

    /// <summary>
    /// Localization management component.
    /// </summary>
    [AddComponentMenu("StvDEV/Game Development Kit/Localization/Localization Manager")]
    [HelpURL("https://docs.stvdev.pro/StvDEV/GDK/Components/Localization/LocalizationManager/index.html")]
    public class LocalizationManager : Manager<LocalizationManager>
    {
        private static string s_language = "en";
        private static readonly UnityEvent<string> s_languageChanged = new();

        /// <summary>
        /// Gets or sets the current language.
        /// </summary>
        public static string Language
        {
            get => s_language;
            set
            {
                s_language = value;
                s_languageChanged?.Invoke(value);
            }
        }

        /// <summary>
        /// On dynamic language changed.
        /// </summary>
        public static UnityEvent<string> LanguageChanged => s_languageChanged;

    }
}
