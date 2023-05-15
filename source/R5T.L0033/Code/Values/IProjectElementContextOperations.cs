using System;
using System.Collections.Generic;
using System.Linq;

using R5T.F0000;
using R5T.L0032.T000;
using R5T.T0131;
using R5T.T0172;

using R5T.L0033.T000;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectElementContextOperations : IValuesMarker
    {
        public Action<IProjectElementContext> Add_MainPropertyGroup =>
            context => Instances.ProjectXmlOperator.Add_MainPropertyGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_PackagePropertyGroup =>
            context => Instances.ProjectXmlOperator.Add_PackagePropertyGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_COMReferencesItemGroup =>
            context => Instances.ProjectXmlOperator.Add_COMReferencesItemGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_ProjectReferencesItemGroup =>
            context => Instances.ProjectXmlOperator.Add_ProjectReferencesItemGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_PackageReferencesItemGroup =>
            context => Instances.ProjectXmlOperator.Add_PackageReferencesItemGroup(context.ProjectElement);

        public Action<IProjectElementContext> Add_CopyToOutputItemGroup =>
            context => Instances.ProjectXmlOperator.Add_CopyToOutputItemGroup(context.ProjectElement);

        /// <inheritdoc cref="L0032.Z000.IProjectSdkNames.NET"/>
        public Action<IProjectElementContext> Set_SDK_Default =>
            context => Instances.ProjectXmlOperator.Set_Sdk(
                context.ProjectElement,
                Instances.ProjectSdkNames.NET);

        /// <inheritdoc cref="ITargetFrameworkMonikers.Console"/>
        public Action<IProjectElementContext> Set_TargetFramework_Console =>
            context => Instances.ProjectXmlOperator.Set_TargetFramework(
                context.ProjectElement,
                Instances.TargetFrameworkMonikers.Console);

        /// <inheritdoc cref="ITargetFrameworkMonikers.Library"/>
        public Action<IProjectElementContext> Set_TargetFramework_Library =>
            context => Instances.ProjectXmlOperator.Set_TargetFramework(
                context.ProjectElement,
                Instances.TargetFrameworkMonikers.Library);

        /// <inheritdoc cref="F0000.IVersions.Default"/>
        public Action<IProjectElementContext> Set_Version_Default =>
            context => Instances.ProjectXmlOperator.Set_Version(
                context.ProjectElement,
                Instances.Versions.Default);

        /// <inheritdoc cref="IAuthors.DCoats"/>
        public Action<IProjectElementContext> Set_Author_DCoats =>
            context => Instances.ProjectXmlOperator.Set_Author(
                context.ProjectElement,
                Instances.Authors.DCoats);

        /// <inheritdoc cref="ICompanyNames.Rivet"/>
        public Action<IProjectElementContext> Set_Company_Rivet =>
            context => Instances.ProjectXmlOperator.Set_Company(
                context.ProjectElement,
                Instances.CompanyNames.Rivet);

        /// <inheritdoc cref="ICompanyNames.Rivet"/>
        public Action<IProjectElementContext> Set_Copyright_Rivet =>
            context => Instances.ProjectXmlOperator.Set_Copyright_FromCopyrightHolder(
                context.ProjectElement,
                Instances.CompanyNames.Rivet.Value);

        public Func<string, Action<IProjectElementContext>> Set_Description =>
            description =>
                context => Instances.ProjectXmlOperator.Set_Description(
                    context.ProjectElement,
                    description);

        /// <inheritdoc cref="L0032.Z000.IOutputTypes.Exe"/>
        public Action<IProjectElementContext> Set_OutputType_Exe =>
            context => Instances.ProjectXmlOperator.Set_OutputType(
                context.ProjectElement,
                Instances.OutputTypes.Exe);

        /// <inheritdoc cref="L0032.Z000.IOutputTypes.Library"/>
        public Action<IProjectElementContext> Set_OutputType_Library =>
            context => Instances.ProjectXmlOperator.Set_OutputType(
                context.ProjectElement,
                Instances.OutputTypes.Library);

        /// <inheritdoc cref="L0032.Z000.IOutputTypes.WinExe"/>
        public Action<IProjectElementContext> Set_OutputType_WinExe =>
            context => Instances.ProjectXmlOperator.Set_OutputType(
                context.ProjectElement,
                Instances.OutputTypes.WinExe);

        /// <inheritdoc cref="L0032.Z000.IPackageLicenseExpressions.MIT"/>
        public Action<IProjectElementContext> Set_PackageLicenseExpression_MIT =>
            context => Instances.ProjectXmlOperator.Set_PackageLicenseExpression(
                context.ProjectElement,
                Instances.PackageLicenseExpressions.MIT);

        /// <summary>
        /// Require license acceptance to use the package.
        /// </summary>
        public Action<IProjectElementContext> Set_PackageRequireLicenseAcceptance =>
            context => Instances.ProjectXmlOperator.Set_PackageRequireLicenseAcceptance(
                context.ProjectElement,
                true);

        public Action<IProjectElementContext> Set_RepositoryUrl(IsSet<IRepositoryUrl> repositoryUrl)
        {
            return projectElementContext =>
            {
                if (repositoryUrl.WasSet)
                {
                    Instances.ProjectXmlOperator.Set_RepositoryUrl(
                        projectElementContext.ProjectElement,
                        repositoryUrl.Value);
                }
            };
        }

        public Func<IRepositoryUrl, Action<IProjectElementContext>> Set_RepositoryUrl_Value =>
            repositoryUrl =>
                context => Instances.ProjectXmlOperator.Set_RepositoryUrl(
                    context.ProjectElement,
                    repositoryUrl);

        public Action<IProjectElementContext> Set_RepositoryUrl(Func<IRepositoryUrl> repositoryUrlProvider)
        {
            var repositoryUrl = repositoryUrlProvider();

            return context => Instances.ProjectXmlOperator.Set_RepositoryUrl(
                context.ProjectElement,
                repositoryUrl);
        }

        /// <inheritdoc cref="L0032.Z000.ICOMReferences.Microsoft_Office_Interop_Excel"/>
        public Action<IProjectElementContext> Add_ExcelCOMReference =>
            context => Instances.ProjectXmlOperator.Add_COMReference(
                context.ProjectElement,
                Instances.COMReferences.Microsoft_Office_Interop_Excel);

        //public Delegates.Add_PackageReferences_Params Add_PackageReferences_Params =>
        public delegate Action<IProjectElementContext> Add_PackageReferences_Params(params PackageReference[] packageReferences);
        public Add_PackageReferences_Params Add_PackageReferences =>
            packageReferences =>
                context => Instances.ProjectXmlOperator.Add_PackageReferences(
                    context.ProjectElement,
                    packageReferences);
        //public Action<IProjectElementContext> Add_PackageReferences(params PackageReference[] packageReferences) =>
        //        context => Instances.ProjectXmlOperator.Add_PackageReferences(
        //            context.ProjectElement,
        //            packageReferences);

        public Func<IEnumerable<PackageReference>, Action<IProjectElementContext>> Add_PackageReferences_Enumerable =>
            packageReferences =>
                context => Instances.ProjectXmlOperator.Add_PackageReferences(
                    context.ProjectElement,
                    packageReferences);

        public delegate Action<IProjectElementContext> Combine_Params(params Action<IProjectElementContext>[] operations);
        public Combine_Params Combine =>
            operations =>
                context => operations.ForEach(x => x(context));

        public delegate Action<IProjectElementContext> Add_ProjectReferenceRelativePaths_Params(params IProjectDirectoryRelativePath[] projectReferenceRelativePaths);
        public Add_ProjectReferenceRelativePaths_Params Add_ProjectReferences =>
            projectReferenceRelativePaths =>
                context => Instances.ProjectXmlOperator.Add_ProjectReferences(
                    context.ProjectElement,
                    projectReferenceRelativePaths);

        public delegate Action<IProjectElementContext> Add_CopyToOutputs_Params(params IProjectDirectoryRelativePath[] fileRelativePaths);
        public Add_CopyToOutputs_Params Add_CopyToOutputs =>
            fileRelativePaths =>
                context => Instances.ProjectXmlOperator.Add_CopyToOutputs(
                    context.ProjectElement,
                    fileRelativePaths);


        //public Action<IProjectElementContext> Set_ =>
        //  context => Instances.ProjectXmlOperator.Set_(
        //      context.ProjectElement, 
        //      Instances.);


    }


    //namespace Delegates
    //{
    //    public delegate Action<IProjectElementContext> Add_PackageReferences_Params(params PackageReference[] packageReferences);
    //}
}
