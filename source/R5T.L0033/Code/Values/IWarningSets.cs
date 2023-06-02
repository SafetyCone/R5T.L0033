using System;

using R5T.T0131;
using R5T.T0202;


namespace R5T.L0033
{
    /// <summary>
    /// Collections of <see cref="T0202.IWarning"/> values for use in project files.
    /// </summary>
    [ValuesMarker]
    public partial interface IWarningSets : IValuesMarker
    {
        private static readonly Lazy<IWarning[]> zDefaultIgnoredWarnings = new Lazy<IWarning[]>(() => new[]
        {
            Instances.Warnings.CS1573,
            Instances.Warnings.CS1587,
            Instances.Warnings.CS1591,
        });
        public IWarning[] DefaultIgnoredWarnings => IWarningSets.zDefaultIgnoredWarnings.Value;
    }
}
