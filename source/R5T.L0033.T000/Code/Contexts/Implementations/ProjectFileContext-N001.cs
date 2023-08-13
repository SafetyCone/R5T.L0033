using System;

using R5T.T0137;
using R5T.T0159;
using R5T.T0172;


namespace R5T.L0033.T000.N001
{
    [ContextImplementationMarker]
    public class ProjectFileContext : IContextImplementationMarker,
        IProjectFileContext
    {
        public IProjectFilePath ProjectFilePath { get; set; }

        public ITextOutput TextOutput { get; set; }
    }
}
