using System;


namespace R5T.L0033
{
    public class ProjectElementContextOperationSequences : IProjectElementContextOperationSequences
    {
        #region Infrastructure

        public static IProjectElementContextOperationSequences Instance { get; } = new ProjectElementContextOperationSequences();


        private ProjectElementContextOperationSequences()
        {
        }

        #endregion
    }
}
