using System;

using R5T.T0137;
using R5T.T0187;


namespace R5T.L0033.T000.N002
{
    /// <summary>
    /// A simple project file context that contains only the project name and project file path (and a text output).
    /// </summary>
    [ContextDefinitionMarker]
    public interface IProjectFileContext : IContextDefinitionMarker,
        N001.IProjectFileContext,
        IHasProjectName
    {
    }
}
