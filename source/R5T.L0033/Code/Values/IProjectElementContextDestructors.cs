using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0172;


namespace R5T.L0033
{
    [ValuesMarker]
    public partial interface IProjectElementContextDestructors : IValuesMarker
    {
        private Internal.IProjectElementContextDestructors Internal => L0033.Internal.ProjectElementContextDestructors.Instance;


        public Func<IProjectFilePath, Action<IProjectElementContext>> Save_Synchronous =>
            projectFilePath =>
                projectElementContext => Internal.Save_Synchronous(projectFilePath, projectElementContext);

        public Func<IProjectFilePath, Func<IProjectElementContext, Task>> Save =>
            projectFilePath =>
                projectElementContext => Internal.Save(projectFilePath, projectElementContext);
    }
}
