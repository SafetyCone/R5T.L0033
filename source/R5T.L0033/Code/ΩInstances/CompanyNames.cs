using System;


namespace R5T.L0033
{
    public class CompanyNames : ICompanyNames
    {
        #region Infrastructure

        public static ICompanyNames Instance { get; } = new CompanyNames();


        private CompanyNames()
        {
        }

        #endregion
    }
}
