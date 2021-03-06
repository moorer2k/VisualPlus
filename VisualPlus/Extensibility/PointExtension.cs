﻿#region Namespace

using System.Drawing;

#endregion

namespace VisualPlus.Extensibility
{
    public static class PointExtension
    {
        #region Methods

        /// <summary>Returns the center point of the rectangle.</summary>
        /// <param name="rectangle">This rectangle.</param>
        /// <returns>The <see cref="Point" />.</returns>
        public static Point Center(this Rectangle rectangle)
        {
            return new Point(rectangle.Left + (rectangle.Width / 2), rectangle.Top + (rectangle.Height / 2));
        }

        #endregion
    }
}