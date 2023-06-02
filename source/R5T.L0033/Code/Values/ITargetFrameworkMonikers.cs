using System;

using R5T.L0032.T000;
using R5T.T0131;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikers : IValuesMarker
    {
        public static L0032.Z000.ITargetFrameworkMonikers Base => L0032.Z000.TargetFrameworkMonikers.Instance;


        /// <inheritdoc cref="L0032.Z000.ITargetFrameworkMonikers.NET_6"/>
        public ITargetFrameworkMoniker NET_6 => Base.NET_6;


        /// <summary>
        /// The default target framework moniker for console projects.
        /// (<inheritdoc cref="L0032.Z000.ITargetFrameworkMonikers.NET_6" path="/summary"/>)
        /// </summary>
        public ITargetFrameworkMoniker Console => Base.NET_6;

        /// <inheritdoc cref="L0032.Z000.ITargetFrameworkMonikers.NET_6"/>
        public ITargetFrameworkMoniker Library => Base.NET_6;
    }
}
