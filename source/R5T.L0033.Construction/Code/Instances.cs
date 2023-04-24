using System;


namespace R5T.L0033.Construction
{
    public static partial class Instances
    {
        public static F0000.IEnumerableOperator EnumerableOperator => F0000.EnumerableOperator.Instance;
        public static F0120.IExecutableFileRelativePathOperator ExecutableFileRelativePathOperator => F0120.ExecutableFileRelativePathOperator.Instance;
        public static Z0015.IFilePaths FilePaths => Z0015.FilePaths.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static L0032.Z000.IPackageReferences PackageReferences => L0032.Z000.PackageReferences.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static IProjectElementContextOperations ProjectElementContextOperations => L0033.ProjectElementContextOperations.Instance;
        public static IProjectElementContextOperationSequences ProjectElementContextOperationSequences => L0033.ProjectElementContextOperationSequences.Instance;
        public static IProjectElementContextOperator ProjectElementContextOperator => L0033.ProjectElementContextOperator.Instance;
        public static IProjectFileContextOperator ProjectFileContextOperator => L0033.ProjectFileContextOperator.Instance;
        public static IProjectFileContextOperations ProjectFileContextOperations => L0033.ProjectFileContextOperations.Instance;
        public static IProjectFilePaths ProjectFilePaths => Construction.ProjectFilePaths.Instance;
        public static L0032.IProjectFileOperator ProjectFileOperator => L0032.ProjectFileOperator.Instance;
        public static L0032.IProjectFileXmlOperator ProjectFileXmlOperator => L0032.ProjectFileXmlOperator.Instance;
    }
}
