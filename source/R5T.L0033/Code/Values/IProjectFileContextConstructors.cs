using System;

using R5T.T0131;
using R5T.T0172;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectFileContextConstructors : IValuesMarker
    {
        private static Internal.IProjectFileContextConstructors Internal => L0033.Internal.ProjectFileContextConstructors.Instance;


        public Func<IProjectFilePath, Func<ProjectFileContext>> New =>
            projectFilePath => 
                () => Internal.New(projectFilePath);
    }
}
