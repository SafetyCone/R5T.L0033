using System;

using R5T.T0137;
using R5T.T0159;
using R5T.T0172;
using R5T.T0187;

namespace R5T.L0033.T000.N002
{
    [ContextImplementationMarker]
    public class ProjectFileContext : IContextImplementationMarker,
        IProjectFileContext
    {
        public IProjectFilePath ProjectFilePath { get; set; }
        public IProjectName ProjectName { get; set; }

        public ITextOutput TextOutput { get; set; }
    }
}
