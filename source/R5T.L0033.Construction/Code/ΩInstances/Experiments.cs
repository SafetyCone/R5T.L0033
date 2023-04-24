using System;


namespace R5T.L0033.Construction
{
    public class Experiments : IExperiments
    {
        #region Infrastructure

        public static IExperiments Instance { get; } = new Experiments();


        private Experiments()
        {
        }

        #endregion
    }
}
