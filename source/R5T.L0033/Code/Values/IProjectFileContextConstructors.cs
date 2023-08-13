using System;

using R5T.T0131;
using R5T.T0159;
using R5T.T0172;
using R5T.T0187;

using R5T.L0033.T000;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectFileContextConstructors : IValuesMarker
    {
        private static Internal.IProjectFileContextConstructors Internal => L0033.Internal.ProjectFileContextConstructors.Instance;


        public Func<ProjectFileContext> New(IProjectFilePath projectFilePath) =>
            () => Internal.New(projectFilePath);

        public Func<ProjectFileContext> New(
            IProjectName projectName,
            IProjectFilePath projectFilePath,
            ITextOutput textOutput)
        {
            return () =>
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
            };
        }
    }
}
