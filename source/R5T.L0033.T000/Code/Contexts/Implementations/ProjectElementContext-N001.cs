using System;
using System.Xml.Linq;

using R5T.L0032.T000;
using R5T.T0137;
using R5T.T0159;
using R5T.T0172;


namespace R5T.L0033.T000.N001
{
    [ContextImplementationMarker]
    public class ProjectElementContext : IContextImplementationMarker,
        IProjectElementContext
    {
        XElement L0032.T000.N001.IHasProjectElement.ProjectElement => this.ProjectElement.Value;
        public IProjectElement ProjectElement { get; set; }

        string T0172.N001.IHasProjectFilePath.ProjectFilePath => this.ProjectFilePath.Value;
        public IProjectFilePath ProjectFilePath { get; set; }

        public ITextOutput TextOutput { get; set; }
    }
}
