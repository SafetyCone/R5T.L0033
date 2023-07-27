using System;

using R5T.T0131;
using R5T.T0218;


namespace R5T.L0033.Z001
{
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikers : IValuesMarker
    {
        public static Z0057.ITargetFrameworkMonikers Base => Z0057.TargetFrameworkMonikers.Instance;


        /// <inheritdoc cref="Z0057.ITargetFrameworkMonikers.NET_6"/>
        public ITargetFrameworkMoniker NET_6 => Base.NET_6;


        /// <summary>
        /// The default target framework moniker for console projects.
        /// (<inheritdoc cref="Z0057.ITargetFrameworkMonikers.NET_6" path="/summary"/>)
        /// </summary>
        public ITargetFrameworkMoniker Console => Base.NET_6;

        /// <inheritdoc cref="Z0057.ITargetFrameworkMonikers.NET_6"/>
        public ITargetFrameworkMoniker Library => Base.NET_6;
    }
}
