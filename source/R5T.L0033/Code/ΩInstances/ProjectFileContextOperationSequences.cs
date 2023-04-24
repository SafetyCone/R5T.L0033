using System;


namespace R5T.L0033
{
    public class ProjectFileContextOperationSequences : IProjectFileContextOperationSequences
    {
        #region Infrastructure

        public static IProjectFileContextOperationSequences Instance { get; } = new ProjectFileContextOperationSequences();


        private ProjectFileContextOperationSequences()
        {
        }

        #endregion
    }
}
