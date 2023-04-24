using System;

using R5T.L0032.T000;
using R5T.T0137;


namespace R5T.L0033
{
    [ContextImplementationMarker]
    public class ProjectElementContext : IContextImplementationMarker,
        IProjectElementContext
    {
        public IProjectElement ProjectElement { get; set; }
    }
}
