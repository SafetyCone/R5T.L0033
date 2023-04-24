using System;


namespace R5T.L0033.Construction
{
    public class ProjectFilePaths : IProjectFilePaths
    {
        #region Infrastructure

        public static IProjectFilePaths Instance { get; } = new ProjectFilePaths();


        private ProjectFilePaths()
        {
        }

        #endregion
    }
}
