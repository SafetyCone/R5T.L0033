using System;

using R5T.L0032.T000;
using R5T.T0137;
using R5T.T0194;


namespace R5T.L0033.T000
{
    [ContextDefinitionMarker]
    public interface IProjectElementContext : IContextDefinitionMarker,
        IHasProjectElement,
        ITextOutputtedContext
    {
    }
}
