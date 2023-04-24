using System;
using System.Xml.Linq;

using R5T.L0032.T000.Extensions;
using R5T.T0132;


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
