using System;


namespace R5T.L0033.T000
{
    public class ProjectElementContextOperator : IProjectElementContextOperator
    {
        #region Infrastructure

        public static IProjectElementContextOperator Instance { get; } = new ProjectElementContextOperator();


        private ProjectElementContextOperator()
        {
        }

        #endregion
    }
}
