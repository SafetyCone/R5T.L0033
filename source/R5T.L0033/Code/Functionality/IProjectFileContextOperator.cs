using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;
using R5T.T0172;


namespace R5T.L0033
{
    [FunctionalityMarker]
    public partial interface IProjectFileContextOperator : IFunctionalityMarker
    {
        public void In_New_ProjectFileContext(
            IProjectFilePath projectFilePath,
            IEnumerable<Action<IProjectFileContext>> operations = default)
        {
            Instances.ContextOperator.In_Context(
                Instances.ProjectFileContextConstructors.New(projectFilePath),
                operations,
                Instances.ProjectElementContextDestructors.Save(projectFilePath));
        }

        public void In_New_ProjectFileContext(
            IProjectFilePath projectFilePath,
            params Action<IProjectFileContext>[] operations)
        {
            this.In_New_ProjectFileContext(
                projectFilePath,
                operations.AsEnumerable());
        }
    }
}
