using System;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180.Extensions;


namespace R5T.L0033.Construction
{
    [ValuesMarker]
    public partial interface IProjectFilePaths : IValuesMarker
    {
        public IProjectFilePath Example01 => Instances.ExecutableFileRelativePathOperator.Get_FilePath(
            @"Files\R5T.L0030.Construction\Example01.csproj".ToRelativeFilePath())
            .AsProjectFilePath();

        public IProjectFilePath Output => @"C:\Temp\Temp.csproj".ToProjectFilePath();
    }
}
