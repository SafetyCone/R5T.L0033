using System;

using R5T.L0031.T000;
using R5T.L0031.T000.Extensions;
using R5T.T0131;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectElementContextOperationSequences : IValuesMarker
    {
        public ISynchronousContextOperationsSequence<IProjectElementContext> None => Instances.EnumerableOperator.Empty<Action<IProjectElementContext>>()
            .ToContextOperationsSequence();
    }
}
