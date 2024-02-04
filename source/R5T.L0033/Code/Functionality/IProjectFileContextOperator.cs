using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0159;
using R5T.T0172;
using R5T.T0187;

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
            Instances.FileSystemOperator.Verify_File_DoesNotExist(
                projectFilePath.Value);

            return Instances.ContextOperator.In_Context(
                Instances.ProjectFileContextConstructors.New(projectFilePath),
                operations,
                Instances.ProjectElementContextDestructors.Save(projectFilePath));
        }

        /// <inheritdoc cref="In_New_ProjectFileContext(IProjectFilePath, IEnumerable{Func{IProjectFileContext, Task}})"/>
        public Task In_New_ProjectFileContext(
            IProjectName projectName,
            IProjectFilePath projectFilePath,
            ITextOutput textOutput,
            IEnumerable<Func<IProjectFileContext, Task>> operations = default)
        {
            Instances.FileSystemOperator.Verify_File_DoesNotExist(
                projectFilePath.Value);

            return Instances.ContextOperator.In_Context(
                Instances.ProjectFileContextConstructors.New(
                    projectName,
                    projectFilePath,
                    textOutput),
                operations,
                Instances.ProjectElementContextDestructors.Save(projectFilePath));
        }

        /// <inheritdoc cref="In_New_ProjectFileContext(IProjectFilePath, IEnumerable{Func{IProjectFileContext, Task}})"/>
        public Task In_New_ProjectFileContext(
            IProjectName projectName,
            IProjectFilePath projectFilePath,
            ITextOutput textOutput,
            params Func<IProjectFileContext, Task>[] operations)
        {
            return this.In_New_ProjectFileContext(
                projectName,
                projectFilePath,
                textOutput,
                operations.AsEnumerable());
        }

        /// <inheritdoc cref="In_New_ProjectFileContext(IProjectFilePath, IEnumerable{Func{IProjectFileContext, Task}})"/>
        public Task In_New_ProjectFileContext(
            IProjectFileContext projectFileContext,
            IEnumerable<Func<IProjectFileContext, Task>> operations = default)
        {
            Instances.FileSystemOperator.Verify_File_DoesNotExist(
                projectFileContext.ProjectFilePath.Value);

            return Instances.ContextOperator.In_Context(
                projectFileContext,
                operations,
                Instances.ProjectElementContextDestructors.Save(projectFileContext.ProjectFilePath));
        }

        /// <inheritdoc cref="In_New_ProjectFileContext(IProjectFilePath, IEnumerable{Func{IProjectFileContext, Task}})"/>
        public Task In_New_ProjectFileContext(
            IProjectFileContext projectFileContext,
            params Func<IProjectFileContext, Task>[] operations)
        {
            return this.In_New_ProjectFileContext(
                projectFileContext,
                operations.AsEnumerable());
        }

        /// <inheritdoc cref="In_New_ProjectFileContext(IProjectFilePath, IEnumerable{Func{IProjectFileContext, Task}})"/>
        public void In_New_ProjectFileContext(
            IProjectFileContext projectFileContext,
            IEnumerable<Action<IProjectFileContext>> operations = default)
        {
            Instances.FileSystemOperator.Verify_File_DoesNotExist(
                projectFileContext.ProjectFilePath.Value);

            Instances.ContextOperator.In_Context(
                projectFileContext,
                operations,
                Instances.ProjectElementContextDestructors.Save_Synchronous(projectFileContext.ProjectFilePath));
        }

        /// <inheritdoc cref="In_New_ProjectFileContext(IProjectFilePath, IEnumerable{Func{IProjectFileContext, Task}})"/>
        public void In_New_ProjectFileContext(
            IProjectFileContext projectFileContext,
            params Action<IProjectFileContext>[] operations)
        {
            this.In_New_ProjectFileContext(
                projectFileContext,
                operations.AsEnumerable());
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
