﻿using System;

using R5T.L0032.T000;
using R5T.T0137;
using R5T.T0159;


namespace R5T.L0033.T000
{
    [ContextImplementationMarker]
    public class ProjectElementContext : IContextImplementationMarker,
        IProjectElementContext
    {
        public IProjectElement ProjectElement { get; set; }

        public ITextOutput TextOutput { get; set; }
    }
}
