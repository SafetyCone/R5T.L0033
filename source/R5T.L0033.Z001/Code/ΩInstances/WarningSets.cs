using System;


namespace R5T.L0033.Z001
{
    public class WarningSets : IWarningSets
    {
        #region Infrastructure

        public static IWarningSets Instance { get; } = new WarningSets();


        private WarningSets()
        {
        }

        #endregion
    }
}
