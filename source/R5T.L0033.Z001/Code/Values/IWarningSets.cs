using System;

using R5T.T0131;
using R5T.T0202;


namespace R5T.L0033.Z001
{
    /// <summary>
    /// Collections of <see cref="IWarning"/> values for use in project files.
    /// </summary>
    [ValuesMarker]
    public partial interface IWarningSets : IValuesMarker
    {
        /// <summary>
        /// The default ignored warnings are:
        /// <list type="bullet">
        /// <item><see cref="Z0048.IWarnings.CS1573"/></item>
        /// <item><see cref="Z0048.IWarnings.CS1587"/></item>
        /// <item><see cref="Z0048.IWarnings.CS1591"/></item>
        /// </list>
        /// </summary>
        private static readonly Lazy<IWarning[]> zDefaultIgnoredWarnings = new(() => new[]
        {
            Instances.Warnings.CS1573,
            Instances.Warnings.CS1587,
            Instances.Warnings.CS1591,
        });

        /// <inheritdoc cref="zDefaultIgnoredWarnings"/>
        public IWarning[] DefaultIgnoredWarnings => IWarningSets.zDefaultIgnoredWarnings.Value;
    }
}
