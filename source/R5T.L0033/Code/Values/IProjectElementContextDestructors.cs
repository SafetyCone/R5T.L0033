using System;

using R5T.T0131;
using R5T.T0172;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectElementContextDestructors : IValuesMarker
    {
        private Internal.IProjectElementContextDestructors Internal => L0033.Internal.ProjectElementContextDestructors.Instance;


        public Func<IProjectFilePath, Action<IProjectElementContext>> Save =>
            projectFilePath => projectElementContext => Internal.Save(projectFilePath, projectElementContext);
    }
}