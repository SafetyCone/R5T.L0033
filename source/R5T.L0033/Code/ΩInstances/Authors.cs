using System;


namespace R5T.L0033
{
    public class Authors : IAuthors
    {
        #region Infrastructure

        public static IAuthors Instance { get; } = new Authors();


        private Authors()
        {
        }

        #endregion
    }
}
