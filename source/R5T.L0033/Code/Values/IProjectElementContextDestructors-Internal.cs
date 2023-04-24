using System;

using R5T.T0132;
using R5T.T0172;


namespace R5T.L0033.Internal
{
    [FunctionalityMarker]
    public partial interface IProjectElementContextDestructors : IFunctionalityMarker
    {
        public void Save(
            IProjectFilePath projectFilePath,
            IProjectElementContext projectElementContext)
        {
            Instances.ProjectFileOperator.Save_Synchronous(
                projectFilePath,
                projectElementContext.ProjectElement);
        }
    }
}
