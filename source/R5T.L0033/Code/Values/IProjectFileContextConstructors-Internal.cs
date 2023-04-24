using System;

using R5T.T0131;
using R5T.T0172;


namespace R5T.L0033.Internal
{
    [ValuesMarker]
    public partial interface IProjectFileContextConstructors : IValuesMarker
    {
        public ProjectFileContext New(IProjectFilePath projectFilePath)
        {
            var projectElement = Instances.ProjectXmlOperator.New_ProjectElement();

            var context = new ProjectFileContext
            {
                ProjectElement = projectElement,
                ProjectFilePath = projectFilePath,
            };

            return context;
        }
    }
}
