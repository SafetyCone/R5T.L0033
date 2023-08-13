using System;

using R5T.T0131;
using R5T.T0159;
using R5T.T0172;
using R5T.T0187;

using R5T.L0033.T000;


namespace R5T.L0033.Internal
{
    [ValuesMarker]
    public partial interface IProjectFileContextConstructors : IValuesMarker
    {
        public ProjectFileContext New(IProjectFilePath projectFilePath)
        {
            var projectElement = Instances.ProjectElementOperator.New_ProjectElement();

            var context = new ProjectFileContext
            {
                ProjectElement = projectElement,
                ProjectFilePath = projectFilePath,
            };

            return context;
        }

        public ProjectFileContext New(
            IProjectName projectName,
            IProjectFilePath projectFilePath,
            ITextOutput textOutput)
        {
            var projectElement = Instances.ProjectElementOperator.New_ProjectElement();

            var context = new ProjectFileContext
            {
                ProjectName = projectName,
                ProjectElement = projectElement,
                ProjectFilePath = projectFilePath,
                TextOutput = textOutput,
            };

            return context;
        }
    }
}
