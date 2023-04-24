using System;


namespace R5T.L0033
{
    public class ProjectElementContextOperations : IProjectElementContextOperations
    {
        #region Infrastructure

        public static IProjectElementContextOperations Instance { get; } = new ProjectElementContextOperations();


        private ProjectElementContextOperations()
        {
        }

        #endregion
    }
}
