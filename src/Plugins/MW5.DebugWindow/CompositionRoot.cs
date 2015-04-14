﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CompositionRoot.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The composition root.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using MW5.Plugins.DebugWindow.Views;

namespace MW5.Plugins.DebugWindow
{
    #region

    using MW5.Plugins.Mvp;

    #endregion

    /// <summary>
    /// The composition root.
    /// </summary>
    internal static class CompositionRoot
    {
        #region Public Methods and Operators

        /// <summary>
        /// Composing the container
        /// </summary>
        /// <param name="container">
        /// The container.
        /// </param>
        public static void Compose(IApplicationContainer container)
        {
            container.RegisterService<DebugDockPanel>();
        }

        #endregion
    }
}