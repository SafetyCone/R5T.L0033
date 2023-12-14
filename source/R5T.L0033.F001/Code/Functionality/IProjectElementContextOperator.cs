using System;
using System.Collections.Generic;
using System.Linq;

using R5T.L0032.T000;
using R5T.L0032.T000.Extensions;
using R5T.T0132;
using R5T.T0159;
using R5T.T0172;


namespace R5T.L0033.F001
{
    [FunctionalityMarker]
    public partial interface IProjectElementContextOperator : IFunctionalityMarker,
        T000.IProjectElementContextOperator
    {
        /// <inheritdoc cref="T000.IProjectElementContextOperator.In_Context(IProjectElement, IProjectFilePath, ITextOutput, IEnumerable{Action{T000.N001.IProjectElementContext}})"/>
        public IProjectElement In_NewProjectElementContext(
            IProjectFilePath expectedProjectFilePath,
            ITextOutput textOutput,
            IEnumerable<Action<T000.N001.IProjectElementContext>> projectElementContextActions)
        {
            var projectElement = Instances.ProjectXElementOperator.New_ProjectXElement()
                .ToProjectElement();

            this.In_Context(
                projectElement,
                expectedProjectFilePath,
                textOutput,
                projectElementContextActions);

            return projectElement;
        }

        /// <inheritdoc cref="T000.IProjectElementContextOperator.In_Context(IProjectElement, IProjectFilePath, ITextOutput, IEnumerable{Action{T000.N001.IProjectElementContext}})"/>
        public IProjectElement In_NewProjectElementContext(
            IProjectFilePath projectFilePath,
            ITextOutput textOutput,
            params Action<T000.N001.IProjectElementContext>[] projectElementContextActions)
        {
            return this.In_NewProjectElementContext(
                projectFilePath,
                textOutput,
                projectElementContextActions.AsEnumerable());
        }
    }
}
