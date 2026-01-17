using UnityEngine;

namespace StvDEV.GDK.Patterns
{
    /// <summary>
    /// Base class for implementing managers.
    /// </summary>
    /// <typeparam name="T">End Manager Type</typeparam>
    public abstract class Manager<T> : MonoBehaviour where T : Manager<T>
    {
        private static T _instance;

        /// <summary>
        /// Manager instance.
        /// </summary>
        protected static T Instance
        {
            get
            {
                if (!_instance)
                {
                    _instance = FindAnyObjectByType<T>();
                    if (!_instance)
                    {
                        Debug.LogError($"[{nameof(Manager<T>)}] Manager of type {typeof(T).FullName} does not exist in the scene.");
                        return null;
                    }
                }

                return _instance;
            }
        }

        /// <summary>
        /// Indicates whether a manager of the given type exists.
        /// </summary>
        public static bool IsExists => Instance != null;

    }
}
