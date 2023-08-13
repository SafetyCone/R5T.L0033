using System;

using R5T.T0137;
using R5T.T0172;
using R5T.T0194;


namespace R5T.L0033.T000.N001
{
    /// <summary>
    /// A simple project file context that contains only the project file path (and a text output).
    /// </summary>
    [ContextDefinitionMarker]
    public interface IProjectFileContext : IContextDefinitionMarker,
        IHasProjectFilePath,
        ITextOutputtedContext
    {
    }
}
