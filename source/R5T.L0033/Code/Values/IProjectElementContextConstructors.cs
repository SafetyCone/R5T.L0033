using System;

using R5T.T0131;
using R5T.T0132;

using R5T.L0033.T000;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectElementContextConstructors : IValuesMarker, IFunctionalityMarker
    {
        private static Internal.IProjectElementContextConstructors Internal => L0033.Internal.ProjectElementContextConstructors.Instance;


        public Func<IProjectElementContext> Default => Internal.Default;
    }
}
