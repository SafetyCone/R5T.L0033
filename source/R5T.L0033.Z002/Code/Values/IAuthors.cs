using System;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;
using R5T.T0131;


namespace R5T.L0033.Z002
{
    [ValuesMarker]
    public partial interface IAuthors : IValuesMarker
    {
        /// <summary>
        /// <see href="https://www.nuget.org/profiles/DCoats">DCoats</see>.
        /// </summary>
        public INugetUserName DCoats => "DCoats".ToNugetUserName();
    }
}
