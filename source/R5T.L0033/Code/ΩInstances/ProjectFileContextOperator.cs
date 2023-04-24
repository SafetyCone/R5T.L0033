using System;


namespace R5T.L0033
{
    public class ProjectFileContextOperator : IProjectFileContextOperator
    {
        #region Infrastructure

        public static IProjectFileContextOperator Instance { get; } = new ProjectFileContextOperator();


        private ProjectFileContextOperator()
        {
        }

        #endregion
    }
}
