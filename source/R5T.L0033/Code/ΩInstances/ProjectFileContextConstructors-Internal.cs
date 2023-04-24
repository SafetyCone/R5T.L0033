using System;


namespace R5T.L0033.Internal
{
    public class ProjectFileContextConstructors : IProjectFileContextConstructors
    {
        #region Infrastructure

        public static IProjectFileContextConstructors Instance { get; } = new ProjectFileContextConstructors();


        private ProjectFileContextConstructors()
        {
        }

        #endregion
    }
}
