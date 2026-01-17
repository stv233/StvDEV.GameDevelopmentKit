using UnityEngine;

namespace StvDEV.GDK.Components.Localization
{
    /// <summary>
    /// Basic localized component.
    /// </summary>
    public abstract class LocalizedComponent : MonoBehaviour
    {
        /// <summary>
        /// Update component localization with language.
        /// </summary>
        /// <param name="language">Language</param>
        public abstract void SetLanguage(string language);
    }
}
