using System;


namespace R5T.L0033
{
    public class ProjectFileContextDestructors : IProjectFileContextDestructors
    {
        #region Infrastructure

        public static IProjectFileContextDestructors Instance { get; } = new ProjectFileContextDestructors();


        private ProjectFileContextDestructors()
        {
        }

        #endregion
    }
}
