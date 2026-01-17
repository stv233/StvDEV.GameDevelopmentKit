using System;
using UnityEngine;

namespace StvDEV.GDK.Inspector
{
    /// <summary>
    /// Draws a two-sided slider in inspector.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property |
       AttributeTargets.Class | AttributeTargets.Struct, Inherited = true)]
    public class MinMaxRangeAttribute : PropertyAttribute
    {
        private readonly float? _maximum;
        private readonly float _minimum;

        /// <summary>
        /// Maximum slider value.
        /// </summary>
        public float? Maximum => _maximum;

        /// <summary>
        /// Minimum slider value.
        /// </summary>
        public float Minimum => _minimum;

        /// <summary>
        /// Draws a two-sided slider in inspector.
        /// </summary>
        public MinMaxRangeAttribute() { }

        /// <summary>
        /// Draws a two-sided slidert in inspector.
        /// </summary>
        /// <param name="maximum">Maximum value</param>
        public MinMaxRangeAttribute(float maximum)
        {
            _maximum = maximum;
            _minimum = 0;
        }

        /// <summary>
        /// Draws a two-sided slider in inspector
        /// </summary>
        /// <param name="maximum">Maximum value</param>
        /// <param name="minimum">Minimum value</param>
        public MinMaxRangeAttribute(float minimum, float maximum)
        {
            _maximum = maximum;
            _minimum = minimum;
        }
    }
}
