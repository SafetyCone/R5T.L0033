using System;
using System.Collections.Generic;
using System.Linq;

using R5T.L0032.T000;
using R5T.T0132;
using R5T.T0159;
using R5T.T0172;


namespace R5T.L0033.T000
{
    [FunctionalityMarker]
    public partial interface IProjectElementContextOperator : IFunctionalityMarker
    {
        /// <summary>
        /// Provides compiler guidance to avoid specifying type arguments when providing project element context operations.
        /// </summary>
        public IEnumerable<Action<N001.IProjectElementContext>> Combine_Actions(
            params Action<N001.IProjectElementContext>[] projectElementContextActions)
        {
            var output = Instances.EnumerableOperator.From(projectElementContextActions);
            return output;
        }

        /// <summary>
        /// Executes the provided actions in an <see cref="N001.IProjectElementContext"/>.
        /// <para>Note: the method does not write the project element to the <paramref name="expectedProjectFilePath"/>; the path is used when adding project or other file references to the project element.</para>
        /// </summary>
        /// <param name="expectedProjectFilePath">The expected project file path for the project element. Used when adding project or other file references to the project element.</param>
        public void In_Context(
            IProjectElement projectElement,
            IProjectFilePath expectedProjectFilePath,
            ITextOutput textOutput,
            IEnumerable<Action<N001.IProjectElementContext>> projectElementContextActions)
        {
            var projectElementContext = new N001.ProjectElementContext
            {
                ProjectElement = projectElement,
                ProjectFilePath = expectedProjectFilePath,
                TextOutput = textOutput,
            };

            Instances.ContextOperator.In_Context(
                projectElementContext,
                projectElementContextActions);
        }

        /// <inheritdoc cref="In_Context(IProjectElement, IProjectFilePath, ITextOutput, IEnumerable{Action{N001.IProjectElementContext}})"/>
        public void In_Context(
            IProjectElement projectElement,
            IProjectFilePath projectFilePath,
            ITextOutput textOutput,
            params Action<N001.IProjectElementContext>[] projectElementContextActions)
        {
            this.In_Context(
                projectElement,
                projectFilePath,
                textOutput,
                projectElementContextActions.AsEnumerable());
        }
    }
}
