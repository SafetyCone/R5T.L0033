using System;

using R5T.T0131;
using R5T.T0172;

namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectFileContextOperations : IValuesMarker
    {
        public delegate Action<IProjectFileContext> Add_ProjectReferences_Params(params IProjectFilePath[] projectFilePaths);
        public Add_ProjectReferences_Params Add_ProjectReferences =>
            projectFilePaths =>
                context =>
                    Instances.ProjectXmlOperator.Add_ProjectReferences(
                        context.ProjectElement,
                        context.ProjectFilePath,
                        projectFilePaths);
    }
}
