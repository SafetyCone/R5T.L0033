using System;
using System.Collections.Generic;
using System.Linq;

using R5T.L0031.T000;
using R5T.T0132;
using R5T.T0172;

using R5T.L0033.T000;


namespace R5T.L0033
{
    [FunctionalityMarker]
    public partial interface IProjectElementContextOperator : IFunctionalityMarker
    {
        public void In_New_ProjectElementContext(
            IProjectFilePath projectFilePath,
            IEnumerable<Action<IProjectElementContext>> operations = default)
        {
            Instances.ContextOperator.In_Context(
                Instances.ProjectElementContextConstructors.Default,
                operations,
                Instances.ProjectElementContextDestructors.Save_Synchronous(projectFilePath));
        }

        public void In_New_ProjectElementContext(
            IProjectFilePath projectFilePath,
            params Action<IProjectElementContext>[] operations)
        {
            this.In_New_ProjectElementContext(
                projectFilePath,
                operations.AsEnumerable());
        }

        public void In_New_ProjectElementContext(
            IProjectFilePath projectFilePath,
            ISynchronousContextOperationsSequence<IProjectElementContext> operations)
        {
            Instances.ContextOperator.In_Context(
                Instances.ProjectElementContextConstructors.Default,
                operations.Value,
                Instances.ProjectElementContextDestructors.Save_Synchronous(projectFilePath));
        }
    }
}
