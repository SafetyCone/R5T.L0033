using System;

using R5T.F0120;
using R5T.F0120.Extensions;
using R5T.T0131;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface ICompanyNames : IValuesMarker
    {
        /// <summary>
        /// Rivet
        /// </summary>
        public ICompanyName Rivet => "Rivet".ToCompanyName();
    }
}
