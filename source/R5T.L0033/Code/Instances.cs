using System;


namespace R5T.L0033
{
    public static class Instances
    {
        public static F0000.IActionOperator ActionOperator => F0000.ActionOperator.Instance;
        public static IAuthors Authors => L0033.Authors.Instance;
        public static ICompanyNames CompanyNames => L0033.CompanyNames.Instance;
        public static Z0051.ICOMReferences COMReferences => Z0051.COMReferences.Instance;
        public static L0031.IContextOperator ContextOperator => L0031.ContextOperator.Instance;
        public static F0000.IEnumerableOperator EnumerableOperator => F0000.EnumerableOperator.Instance;
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static L0032.Z000.IOutputTypes OutputTypes => L0032.Z000.OutputTypes.Instance;
        public static L0032.Z000.IPackageLicenseExpressions PackageLicenseExpressions => L0032.Z000.PackageLicenseExpressions.Instance;
        public static Z0050.IPackageReferences PackageReferences => Z0050.PackageReferences.Instance;
        public static IProjectElementContextConstructors ProjectElementContextConstructors => L0033.ProjectElementContextConstructors.Instance;
        public static IProjectElementContextDestructors ProjectElementContextDestructors => L0033.ProjectElementContextDestructors.Instance;
        public static IProjectElementContextOperations ProjectElementContextOperations => L0033.ProjectElementContextOperations.Instance;
        public static IProjectFileContextConstructors ProjectFileContextConstructors => L0033.ProjectFileContextConstructors.Instance;
        public static L0032.IProjectElementOperator ProjectElementOperator => L0032.ProjectElementOperator.Instance;
        public static L0032.Z000.IProjectElementNames ProjectElementNames => L0032.Z000.ProjectElementNames.Instance;
        public static L0032.IProjectFileOperator ProjectFileOperator => L0032.ProjectFileOperator.Instance;
        public static L0032.Z000.IProjectSdkNames ProjectSdkNames => L0032.Z000.ProjectSdkNames.Instance;
        public static L0032.IProjectXmlOperator ProjectXmlOperator => L0032.ProjectXmlOperator.Instance;
        public static L0032.Z000.ISupportedPlatforms SupportedPlatforms => L0032.Z000.SupportedPlatforms.Instance;
        public static ITargetFrameworkMonikers TargetFrameworkMonikers => L0033.TargetFrameworkMonikers.Instance;
        public static F0000.IVersions Versions => F0000.Versions.Instance;
        public static Z0048.IWarnings Warnings => Z0048.Warnings.Instance;
        public static IWarningSets WarningSets => L0033.WarningSets.Instance;
    }
}