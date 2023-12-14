using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using R5T.F0000;
using R5T.F0000.Extensions;
using R5T.L0031.Extensions;
using R5T.T0131;
using R5T.T0172;
using R5T.T0187;
using R5T.T0198;

using R5T.L0033.T000;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectFileContextOperations : IValuesMarker
    {
        public Func<IProjectFileContext, Task> Setup_RazorClassLibraryProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return projectFileContext =>
            {
                var operations = this.Setup_ProjectFileBaseOperations(
                    projectDescription,
                    repositoryUrl,
                    Instances.ProjectElementContextOperations.Set_SDK_Razor,
                    Instances.ProjectElementContextOperations.Set_TargetFramework_NET_6,
                    Instances.ProjectElementContextOperations.Set_SupportedPlatform_Browser,
                    Instances.ProjectElementContextOperations.Add_PackageReferences(
                        Instances.PackageReferences.Microsoft_AspNetCore_Components_Web)
                );

                projectFileContext.Run(operations);

                return Task.CompletedTask;
            };
        }

        /// <summary>
        /// The project file for an ASP.NET server project for a Blazor client project.
        /// </summary>
        public Func<IProjectFileContext, Task> Setup_BlazorClientProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return projectFileContext =>
            {
                var operations = this.Setup_ProjectFileBaseOperations(
                    projectDescription,
                    repositoryUrl,
                    Instances.ProjectElementContextOperations.Set_SDK_BlazorWebAssembly,
                    Instances.ProjectElementContextOperations.Set_TargetFramework_NET_6,
                    Instances.ProjectElementContextOperations.Add_PackageReferences(
                        Instances.PackageReferences.Microsoft_AspNetCore_Components_WebAssembly,
                        Instances.PackageReferences.Microsoft_AspNetCore_Components_WebAssembly_DevServer)
                );

                projectFileContext.Run(operations);

                return Task.CompletedTask;
            };
        }

        /// <summary>
        /// The project file for an ASP.NET server project for a Blazor client project.
        /// </summary>
        public Func<IProjectFileContext, Task> Setup_WebServerForBlazorClientProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl,
            Func<IProjectFilePath> clientProjectFilePathProvider)
        {
            return projectFileContext =>
            {
                var clientProjectFilePath = clientProjectFilePathProvider();

                var operations = this.Setup_ProjectFileBaseOperations(
                    projectDescription,
                    repositoryUrl,
                    Instances.ProjectElementContextOperations.Set_SDK_Web,
                    Instances.ProjectElementContextOperations.Set_TargetFramework_NET_6,
                    Instances.ProjectElementContextOperations.Add_ProjectReferences(
                        projectFileContext.ProjectFilePath,
                        clientProjectFilePath),
                    Instances.ProjectElementContextOperations.Add_PackageReferences(
                        Instances.PackageReferences.Microsoft_AspNetCore_Components_WebAssembly_Server)
                );

                projectFileContext.Run(operations);

                return Task.CompletedTask;
            };
        }

        public Action<IProjectFileContext> Add_ProjectReferences(params IProjectFilePath[] projectFilePaths) =>
            context =>
                Instances.ProjectXmlOperator.Add_ProjectReferences(
                    context.ProjectElement,
                    context.ProjectFilePath,
                    projectFilePaths);

        /// <inheritdoc cref="Setup_ConsoleProjectFile(IProjectDescription, IsSet{IRepositoryUrl})"/>
        public Func<IProjectFileContext, Task> Create_ProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return this.Setup_ConsoleProjectFile(
                projectDescription,
                repositoryUrl);
        }

        public Action<IProjectFileContext> Order_MainNodes =>
            Instances.ProjectElementContextOperations.Order_MainPropertyGroupNodes;

        public Action<IProjectFileContext> Set_DefaultPackageInformation(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return Instances.ActionOperator.Combine(
                this.Set_DefaultPackageInformationOperations(
                    projectDescription,
                    repositoryUrl
                )
            );
        }

        public IEnumerable<Action<IProjectFileContext>> Set_DefaultPackageInformationOperations(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return Instances.EnumerableOperator.From(
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
            );
        }

        public IEnumerable<Action<IProjectFileContext>> Setup_ProjectFile_WithLibraryBaseOperations()
        {
            return Instances.EnumerableOperator.From(
                Instances.ProjectElementContextOperations.Set_TargetFramework_Library,
                Instances.ProjectElementContextOperations.Set_SDK_Default,
                Instances.ProjectElementContextOperations.Set_IgnoredWarnings_Default,
                Instances.ProjectElementContextOperations.Set_GenerateDocumentationFile);
        }

        public IEnumerable<Action<IProjectFileContext>> Setup_ProjectFileBaseOperations(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl,
            IEnumerable<Action<IProjectFileContext>> setupProjectFileOperations)
        {
            var output = setupProjectFileOperations
                .Prepend(
                    Instances.ProjectElementContextOperations.Set_SDK_Default,
                    Instances.ProjectElementContextOperations.Set_IgnoredWarnings_Default,
                    Instances.ProjectElementContextOperations.Set_GenerateDocumentationFile
                )
                .Append(
                    this.Order_MainNodes,
                    this.Set_DefaultPackageInformation(
                        projectDescription,
                        repositoryUrl
                    )
                )
                ;

            return output;
        }

        public IEnumerable<Action<IProjectFileContext>> Setup_ProjectFileBaseOperations(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl,
            params Action<IProjectFileContext>[] setupProjectFileOperations)
        {
            return this.Setup_ProjectFileBaseOperations(
                projectDescription,
                repositoryUrl,
                setupProjectFileOperations.AsEnumerable());
        }

        /// <summary>
        /// The default console project file creation operation.
        /// (Console project, .NET 6.0, sets default package information.)
        /// </summary>
        public Func<IProjectFileContext, Task> Setup_ConsoleProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return projectFileContext =>
            {
                var operations = this.Setup_ProjectFileBaseOperations(
                    projectDescription,
                    repositoryUrl,
                    Instances.ProjectElementContextOperations.Set_TargetFramework_Console,
                    Instances.ProjectElementContextOperations.Set_OutputType_Exe
                );

                projectFileContext.Run(operations);

                return Task.CompletedTask;
            };
        }

        /// <summary>
        /// The default library project file creation operation.
        /// (Console project, .NET 6.0, sets default package information.)
        /// </summary>
        public Func<IProjectFileContext, Task> Setup_LibraryProjectFile(
            IProjectDescription projectDescription,
            IsSet<IRepositoryUrl> repositoryUrl)
        {
            return projectFileContext =>
            {
                var operations = this.Setup_ProjectFileBaseOperations(
                    projectDescription,
                    repositoryUrl,
                    Instances.ProjectElementContextOperations.Set_TargetFramework_Library,
                    Instances.ProjectElementContextOperations.Set_OutputType_Library
                );

                projectFileContext.Run(operations);

                return Task.CompletedTask;
            };
        }
    }
}
