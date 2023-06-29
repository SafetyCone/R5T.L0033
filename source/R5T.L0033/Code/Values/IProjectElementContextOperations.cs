using System;
using System.Collections.Generic;

using R5T.F0000;
using R5T.T0131;
using R5T.T0172;
using R5T.T0198;
using R5T.T0202;
using R5T.T0205;

using R5T.L0033.T000;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectElementContextOperations : IValuesMarker
    {
        public Action<IProjectElementContext> Add_MainPropertyGroup =>
            context => Instances.ProjectXmlOperator.Add_MainPropertyGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_PackagePropertyGroup =>
            context => Instances.ProjectElementOperator.Add_PackagePropertyGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_COMReferencesItemGroup =>
            context => Instances.ProjectXmlOperator.Add_COMReferencesItemGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_ProjectReferencesItemGroup =>
            context => Instances.ProjectXmlOperator.Add_ProjectReferencesItemGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_PackageReferencesItemGroup =>
            context => Instances.ProjectXmlOperator.Add_PackageReferencesItemGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_CopyToOutputItemGroup =>
            context => Instances.ProjectXmlOperator.Add_CopyToOutputItemGroup(context.ProjectElement);

        public Action<IProjectElementContext> Order_MainPropertyGroupNodes =>
            context => Instances.ProjectElementOperator.Order_MainPropertyGroupNodes(
                context.ProjectElement);

        /// <inheritdoc cref="Z002.IAuthors.DCoats"/>
        public Action<IProjectElementContext> Set_Author_DCoats =>
            context => Instances.ProjectElementOperator.Set_Author(
                context.ProjectElement,
                Instances.Authors.DCoats);

        /// <inheritdoc cref="L0032.Z000.IProjectSdkNames.NET"/>
        public Action<IProjectElementContext> Set_SDK_Default =>
            context => Instances.ProjectXmlOperator.Set_Sdk(
                context.ProjectElement,
                Instances.ProjectSdkNames.NET);

        /// <inheritdoc cref="L0032.Z000.IProjectSdkNames.Web"/>
        public Action<IProjectElementContext> Set_SDK_Web =>
            context => Instances.ProjectXmlOperator.Set_Sdk(
                context.ProjectElement,
                Instances.ProjectSdkNames.Web);

        /// <inheritdoc cref="L0032.Z000.IProjectSdkNames.BlazorWebAssembly"/>
        public Action<IProjectElementContext> Set_SDK_BlazorWebAssembly =>
            context => Instances.ProjectXmlOperator.Set_Sdk(
                context.ProjectElement,
                Instances.ProjectSdkNames.BlazorWebAssembly);

        /// <inheritdoc cref="L0032.Z000.IProjectSdkNames.Razor"/>
        public Action<IProjectElementContext> Set_SDK_Razor =>
            context => Instances.ProjectXmlOperator.Set_Sdk(
                context.ProjectElement,
                Instances.ProjectSdkNames.Razor);

        /// <inheritdoc cref="L0032.Z000.ISupportedPlatforms.Browser"/>
        public Action<IProjectElementContext> Set_SupportedPlatform_Browser =>
            context => Instances.ProjectElementOperator.Set_SupportedPlatform(
                context.ProjectElement,
                Instances.SupportedPlatforms.Browser);

        /// <inheritdoc cref="Z001.ITargetFrameworkMonikers.Console"/>
        public Action<IProjectElementContext> Set_TargetFramework_Console =>
            context => Instances.ProjectElementOperator.Set_TargetFramework(
                context.ProjectElement,
                Instances.TargetFrameworkMonikers.Console);

        /// <inheritdoc cref="Z001.ITargetFrameworkMonikers.NET_6"/>
        public Action<IProjectElementContext> Set_TargetFramework_NET_6 =>
            context => Instances.ProjectElementOperator.Set_TargetFramework(
                context.ProjectElement,
                Instances.TargetFrameworkMonikers.NET_6);

        /// <inheritdoc cref="Z001.ITargetFrameworkMonikers.Library"/>
        public Action<IProjectElementContext> Set_TargetFramework_Library =>
            context => Instances.ProjectElementOperator.Set_TargetFramework(
                context.ProjectElement,
                Instances.TargetFrameworkMonikers.Library);

        /// <inheritdoc cref="IVersions.Default"/>
        public Action<IProjectElementContext> Set_Version_Default =>
            context => Instances.ProjectElementOperator.Set_Version(
                context.ProjectElement,
                Instances.Versions.Default);

        /// <inheritdoc cref="Z002.ICompanyNames.Rivet"/>
        public Action<IProjectElementContext> Set_Company_Rivet =>
            context => Instances.ProjectElementOperator.Set_Company(
                context.ProjectElement,
                Instances.CompanyNames.Rivet);

        /// <inheritdoc cref="Z002.ICompanyNames.Rivet"/>
        public Action<IProjectElementContext> Set_Copyright_Rivet =>
            context => Instances.ProjectElementOperator.Set_Copyright_FromCopyrightHolder(
                context.ProjectElement,
                Instances.CompanyNames.Rivet.Value);

        public Func<string, Action<IProjectElementContext>> Set_Description =>
            description =>
                context => Instances.ProjectElementOperator.Set_Description(
                    context.ProjectElement,
                    description);

        /// <inheritdoc cref="L0032.Z000.IOutputTypes.Exe"/>
        public Action<IProjectElementContext> Set_OutputType_Exe =>
            context => Instances.ProjectElementOperator.Set_OutputType(
                context.ProjectElement,
                Instances.OutputTypes.Exe);

        /// <inheritdoc cref="L0032.Z000.IOutputTypes.Library"/>
        public Action<IProjectElementContext> Set_OutputType_Library =>
            context => Instances.ProjectElementOperator.Set_OutputType(
                context.ProjectElement,
                Instances.OutputTypes.Library);

        /// <inheritdoc cref="L0032.Z000.IOutputTypes.WinExe"/>
        public Action<IProjectElementContext> Set_OutputType_WinExe =>
            context => Instances.ProjectElementOperator.Set_OutputType(
                context.ProjectElement,
                Instances.OutputTypes.WinExe);

        /// <inheritdoc cref="L0032.Z000.IPackageLicenseExpressions.MIT"/>
        public Action<IProjectElementContext> Set_PackageLicenseExpression_MIT =>
            context => Instances.ProjectElementOperator.Set_PackageLicenseExpression(
                context.ProjectElement,
                Instances.PackageLicenseExpressions.MIT);

        /// <summary>
        /// Require license acceptance to use the package.
        /// </summary>
        public Action<IProjectElementContext> Set_PackageRequireLicenseAcceptance =>
            context => Instances.ProjectElementOperator.Set_PackageRequireLicenseAcceptance(
                context.ProjectElement,
                true);

        public Action<IProjectElementContext> Set_RepositoryUrl(IsSet<IRepositoryUrl> repositoryUrl)
        {
            return projectElementContext =>
            {
                if (repositoryUrl.WasSet)
                {
                    Instances.ProjectElementOperator.Set_RepositoryUrl(
                        projectElementContext.ProjectElement,
                        repositoryUrl.Value);
                }
            };
        }

        public Func<IRepositoryUrl, Action<IProjectElementContext>> Set_RepositoryUrl_Value =>
            repositoryUrl =>
                context => Instances.ProjectElementOperator.Set_RepositoryUrl(
                    context.ProjectElement,
                    repositoryUrl);

        public Action<IProjectElementContext> Set_RepositoryUrl(Func<IRepositoryUrl> repositoryUrlProvider)
        {
            var repositoryUrl = repositoryUrlProvider();

            return context => Instances.ProjectElementOperator.Set_RepositoryUrl(
                context.ProjectElement,
                repositoryUrl);
        }

        /// <inheritdoc cref="Z0051.ICOMReferences.Microsoft_Office_Interop_Excel"/>
        public Action<IProjectElementContext> Add_ExcelCOMReference =>
            context => Instances.ProjectXmlOperator.Add_COMReference(
                context.ProjectElement,
                Instances.COMReferences.Microsoft_Office_Interop_Excel);

        public Action<IProjectElementContext> Add_PackageReferences(params PackageReference[] packageReferences)
            => context => Instances.ProjectXmlOperator.Add_PackageReferences(
                context.ProjectElement,
                packageReferences);

        public Func<IEnumerable<PackageReference>, Action<IProjectElementContext>> Add_PackageReferences_Enumerable =>
            packageReferences =>
                context => Instances.ProjectXmlOperator.Add_PackageReferences(
                    context.ProjectElement,
                    packageReferences);

        public Action<IProjectElementContext> Combine(params Action<IProjectElementContext>[] operations)
            => Instances.ActionOperator.Combine(operations);

        public Action<IProjectElementContext> Add_ProjectReferences(params IProjectDirectoryRelativePath[] projectReferenceRelativePaths)
            => context => Instances.ProjectXmlOperator.Add_ProjectReferences(
                    context.ProjectElement,
                    projectReferenceRelativePaths);

        public Action<IProjectElementContext> Add_ProjectReferences(
            IProjectFilePath projectFilePath,
            params IProjectFilePath[] projectReferenceFilePaths)
            => context => Instances.ProjectXmlOperator.Add_ProjectReferences(
                    context.ProjectElement,
                    projectFilePath,
                    projectReferenceFilePaths);

        public Action<IProjectElementContext> Add_CopyToOutputs(params IProjectDirectoryRelativePath[] fileRelativePaths)
            => context
                => Instances.ProjectXmlOperator.Add_CopyToOutputs(
                    context.ProjectElement,
                    fileRelativePaths);

        public Action<IProjectElementContext> Set_IgnoredWarnings(IEnumerable<IWarning> warnings)
        {
            return context =>
                Instances.ProjectElementOperator.Set_NoWarn(
                    context.ProjectElement,
                    warnings
                );
        }

        public Action<IProjectElementContext> Set_IgnoredWarnings_Default
            => this.Set_IgnoredWarnings(
                Instances.WarningSets.DefaultIgnoredWarnings);

        public Action<IProjectElementContext> Set_GenerateDocumentationFile
            => context
                => Instances.ProjectElementOperator.Set_GenerateDocumentationFile(
                    context.ProjectElement);
    }
}
