using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0172;

using R5T.L0033.T000;


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
                Instances.ProjectElementContextDestructors.Save_Synchronous(projectFilePath));
        }

        /// <summary>
        /// Because this is the 'new' operation, it will throw an exception if the project file already exists.
        /// </summary>
        public Task In_New_ProjectFileContext(
            IProjectFilePath projectFilePath,
            IEnumerable<Func<IProjectFileContext, Task>> operations = default)
        {
            Instances.FileSystemOperator.VerifyFileDoesNotExists(
                projectFilePath.Value);

            return Instances.ContextOperator.In_Context(
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

        public Task In_New_ProjectFileContext_Task(
            IProjectFilePath projectFilePath,
            params Action<IProjectFileContext>[] operations)
        {
            this.In_New_ProjectFileContext(
                projectFilePath,
                operations.AsEnumerable());

            return Task.CompletedTask;
        }

        /// <inheritdoc cref="In_New_ProjectFileContext(IProjectFilePath, IEnumerable{Func{IProjectFileContext, Task}})"/>
        public Task In_New_ProjectFileContext(
            IProjectFilePath projectFilePath,
            params Func<IProjectFileContext, Task>[] operations)
        {
            return this.In_New_ProjectFileContext(
                projectFilePath,
                operations.AsEnumerable());
        }
    }
}
