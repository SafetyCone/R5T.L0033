using System;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.L0031.Extensions;
using R5T.L0032.T000;
using R5T.T0131;
using R5T.T0172;
using R5T.T0187;

using R5T.L0033.T000;


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

        /// <inheritdoc cref="Create_ConsoleProjectFile(IProjectDescription, IsSet{IRepositoryUrl})"/>
        public Func<IProjectFileContext, Task> Create_ProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return this.Create_ConsoleProjectFile(
                projectDescription,
                repositoryUrl);
        }

        /// <summary>
        /// The default console project file creation operation.
        /// (Console project, .NET 6.0, sets default package information.)
        /// </summary>
        public Func<IProjectFileContext, Task> Create_ConsoleProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return projectFileContext =>
            {
                projectFileContext.Run(
                    Instances.ProjectElementContextOperations.Set_SDK_Default,
                    Instances.ProjectElementContextOperations.Set_TargetFramework_Console,
                    Instances.ProjectElementContextOperations.Set_OutputType_Exe,
                    Instances.ProjectElementContextOperations.Combine(
                        Instances.ProjectElementContextOperations.Set_Version_Default,
                        Instances.ProjectElementContextOperations.Set_Author_DCoats,
                        Instances.ProjectElementContextOperations.Set_Company_Rivet,
                        Instances.ProjectElementContextOperations.Set_Copyright_Rivet,
                        Instances.ProjectElementContextOperations.Set_Description(
                            projectDescription.Value),
                        Instances.ProjectElementContextOperations.Set_PackageLicenseExpression_MIT,
                        Instances.ProjectElementContextOperations.Set_PackageRequireLicenseAcceptance,
                        Instances.ProjectElementContextOperations.Set_RepositoryUrl(
                            repositoryUrl)
                    )
                );

                return Task.CompletedTask;
            };
        }

        /// <summary>
        /// The default library project file creation operation.
        /// (Console project, .NET 6.0, sets default package information.)
        /// </summary>
        public Func<IProjectFileContext, Task> Create_LibraryProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return projectFileContext =>
            {
                projectFileContext.Run(
                    Instances.ProjectElementContextOperations.Set_SDK_Default,
                    Instances.ProjectElementContextOperations.Set_TargetFramework_Library,
                    Instances.ProjectElementContextOperations.Set_OutputType_Library,
                    Instances.ProjectElementContextOperations.Combine(
                        Instances.ProjectElementContextOperations.Set_Version_Default,
                        Instances.ProjectElementContextOperations.Set_Author_DCoats,
                        Instances.ProjectElementContextOperations.Set_Company_Rivet,
                        Instances.ProjectElementContextOperations.Set_Copyright_Rivet,
                        Instances.ProjectElementContextOperations.Set_Description(
                            projectDescription.Value),
                        Instances.ProjectElementContextOperations.Set_PackageLicenseExpression_MIT,
                        Instances.ProjectElementContextOperations.Set_PackageRequireLicenseAcceptance,
                        Instances.ProjectElementContextOperations.Set_RepositoryUrl(
                            repositoryUrl)
                    )
                );

                return Task.CompletedTask;
            };
        }
    }
}
