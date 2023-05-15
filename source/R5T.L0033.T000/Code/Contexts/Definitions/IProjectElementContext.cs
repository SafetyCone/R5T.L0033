using System;

using R5T.L0032.T000;
using R5T.T0137;


namespace R5T.L0033.T000
{
    [ContextDefinitionMarker]
    public interface IProjectElementContext : IContextDefinitionMarker
    {
        public IProjectElement ProjectElement { get; }
    }
}
