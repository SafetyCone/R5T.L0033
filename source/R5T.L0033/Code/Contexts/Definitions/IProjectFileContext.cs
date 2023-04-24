using System;

using R5T.T0137;
using R5T.T0172;


namespace R5T.L0033
{
    [ContextDefinitionMarker]
    public interface IProjectFileContext : IContextDefinitionMarker,
        IProjectElementContext
    {
        public IProjectFilePath ProjectFilePath { get; }
    }
}
