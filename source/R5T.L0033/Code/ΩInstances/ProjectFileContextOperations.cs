using System;


namespace R5T.L0033
{
    public class ProjectFileContextOperations : IProjectFileContextOperations
    {
        #region Infrastructure

        public static IProjectFileContextOperations Instance { get; } = new ProjectFileContextOperations();


        private ProjectFileContextOperations()
        {
        }

        #endregion
    }
}
