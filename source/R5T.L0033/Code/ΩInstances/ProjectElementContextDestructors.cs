using System;


namespace R5T.L0033
{
    public class ProjectElementContextDestructors : IProjectElementContextDestructors
    {
        #region Infrastructure

        public static IProjectElementContextDestructors Instance { get; } = new ProjectElementContextDestructors();


        private ProjectElementContextDestructors()
        {
        }

        #endregion
    }
}
