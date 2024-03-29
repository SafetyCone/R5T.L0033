﻿using System;

using R5T.L0032.T000;
using R5T.T0137;
using R5T.T0159;
using R5T.T0172;
using R5T.T0187;


namespace R5T.L0033.T000
{
    [ContextImplementationMarker]
    public class ProjectFileContext : IContextImplementationMarker,
        IProjectFileContext
    {
        public IProjectName ProjectName { get; set; }
        public IProjectElement ProjectElement { get; set; }
        public IProjectFilePath ProjectFilePath { get; set; }

        public ITextOutput TextOutput { get; set; }

    }
}
