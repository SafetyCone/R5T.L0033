using System;

using R5T.L0032.T000.Extensions;
using R5T.T0141;
using R5T.T0172.Extensions;
using R5T.T0181.Extensions;


namespace R5T.L0033.Construction
{
    [ExperimentsMarker]
    public partial interface IExperiments : IExperimentsMarker
    {
        public void Create_InitialProject()
        {
            /// Inputs.
            var description = "A project writing project test.";
            var repositoryUrl = "https://github.com/SafetyCone/R5T.F0069.git".ToRepositoryUrl();

            var outputFilePath = Instances.ProjectFilePaths.Output;


            /// Run.
            //Instances.ProjectElementContextOperator.In_ProjectElementContext(
            Instances.ProjectFileContextOperator.In_New_ProjectFileContext(
                // Try with empty.
                outputFilePath,
                //new[]
                //{
                //Instances.EnumerableOperator.From(
                    Instances.ProjectElementContextOperations.Set_SDK_Default,
                    Instances.ProjectElementContextOperations.Add_MainPropertyGroup,
                    Instances.ProjectElementContextOperations.Add_PackagePropertyGroup,
                    Instances.ProjectElementContextOperations.Add_COMReferencesItemGroup,
                    Instances.ProjectElementContextOperations.Add_ProjectReferencesItemGroup,
                    Instances.ProjectElementContextOperations.Add_PackageReferencesItemGroup,
                    Instances.ProjectElementContextOperations.Add_CopyToOutputItemGroup,
                    Instances.ProjectElementContextOperations.Set_TargetFramework_Library,
                    Instances.ProjectElementContextOperations.Combine(
                        Instances.ProjectElementContextOperations.Set_Version_Default,
                        Instances.ProjectElementContextOperations.Set_Author_DCoats,
                        Instances.ProjectElementContextOperations.Set_Company_Rivet,
                        Instances.ProjectElementContextOperations.Set_Copyright_Rivet,
                        Instances.ProjectElementContextOperations.Set_Description(description),
                        Instances.ProjectElementContextOperations.Set_PackageLicenseExpression_MIT,
                        Instances.ProjectElementContextOperations.Set_PackageRequireLicenseAcceptance,
                        Instances.ProjectElementContextOperations.Set_RepositoryUrl_Value(repositoryUrl)),
                    Instances.ProjectElementContextOperations.Add_ExcelCOMReference,
                    Instances.ProjectElementContextOperations.Add_PackageReferences(
                        //new []
                        //{
                            Instances.PackageReferences.Microsoft_NET_Test_Sdk,
                            Instances.PackageReferences.MSTest_TestAdapter
                        //}
                        ),
                    Instances.ProjectElementContextOperations.Add_ProjectReferences(
                        @"..\..\..\R5T.F0000\source\R5T.F0000\R5T.F0000.csproj".ToProjectDirectoryRelativePath()
                        ),
                    Instances.ProjectFileContextOperations.Add_ProjectReferences(
                        @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.NG0011\source\R5T.NG0011\R5T.NG0011.csproj".ToProjectFilePath()
                        ),
                    Instances.ProjectElementContextOperations.Add_CopyToOutputs(
                        @"Files\R5T.L0030.Z000\Example01.xml".ToProjectDirectoryRelativePath()
                        )
                //}
                //)
                );

            // See the output.            
            Instances.NotepadPlusPlusOperator.Open(outputFilePath.Value);
        }

        public void Create_EmptyProject()
        {
            /// Inputs.
            var outputFilePath = Instances.ProjectFilePaths.Output;


            /// Run.
            Instances.ProjectElementContextOperator.In_New_ProjectElementContext(
                //// Try with empty.
                //outputFilePath);
                // Try with none.
                outputFilePath,
                Instances.ProjectElementContextOperationSequences.None);

            // See the output.            
            Instances.NotepadPlusPlusOperator.Open(outputFilePath.Value);
        }

        /// <summary>
        /// Select the root project element from a project file document.
        /// Bonus: write out the project element as an arbitrary element.
        /// </summary>
        public void Get_ProjectElement()
        {
            /// Inputs.
            var outputFilePath = Instances.FilePaths.OutputXmlFilePath
                .ToXmlFilePath();


            /// Run.
            // Load the project file.
            var projectDocument = Instances.ProjectFileOperator.Load_Synchronous(
                Instances.ProjectFilePaths.Example01);

            // Select the root project element.
            var projectElement = Instances.ProjectFileXmlOperator.Get_ProjectElement(projectDocument);

            // Save the project element.
            // Use this XML-level operator since for this experiment we are working at the XML level.
#pragma warning disable CS0618 // Type or member is obsolete
            Instances.XmlOperator.Save_Synchronous(
                outputFilePath,
                projectElement.Value);
#pragma warning restore CS0618 // Type or member is obsolete

            // See the output.            
            Instances.NotepadPlusPlusOperator.Open(outputFilePath.Value);
        }
    }
}
