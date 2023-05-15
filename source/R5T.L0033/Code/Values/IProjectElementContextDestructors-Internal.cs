using System;
using System.Threading.Tasks;

using R5T.T0132;
using R5T.T0172;

using R5T.L0033.T000;


namespace R5T.L0033.Internal
{
    [FunctionalityMarker]
    public partial interface IProjectElementContextDestructors : IFunctionalityMarker
    {
        public void Save_Synchronous(
            IProjectFilePath projectFilePath,
            IProjectElementContext projectElementContext)
        {
            Instances.ProjectFileOperator.Save_Synchronous(
                projectFilePath,
                projectElementContext.ProjectElement);
        }

        public Task Save(
            IProjectFilePath projectFilePath,
            IProjectElementContext projectElementContext)
        {
            return Instances.ProjectFileOperator.Save(
                projectFilePath,
                projectElementContext.ProjectElement);
        }
    }
}
