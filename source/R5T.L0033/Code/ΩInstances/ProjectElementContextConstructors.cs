using System;


namespace R5T.L0033
{
    public class ProjectElementContextConstructors : IProjectElementContextConstructors
    {
        #region Infrastructure

        public static IProjectElementContextConstructors Instance { get; } = new ProjectElementContextConstructors();


        private ProjectElementContextConstructors()
        {
        }

        #endregion
    }
}
