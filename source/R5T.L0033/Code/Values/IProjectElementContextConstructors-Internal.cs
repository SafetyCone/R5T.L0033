using System;

using R5T.T0132;

using R5T.L0033.T000;


namespace R5T.L0033.Internal
{
    [FunctionalityMarker]
    public partial interface IProjectElementContextConstructors : IFunctionalityMarker
    {
        public ProjectElementContext Default()
        {
            var projectElement = Instances.ProjectXmlOperator.New_ProjectElement();

            var context = new ProjectElementContext
            {
                ProjectElement = projectElement,
            };

            return context;
        }
    }
}
