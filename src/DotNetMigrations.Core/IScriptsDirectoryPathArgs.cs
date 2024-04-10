namespace DotNetMigrations.Core
{
    public interface IScriptsDirectoryPathArgs
    {
        string ScriptsDirectoryPath { get; set; }

        string ScriptsSearchPattern { get; set; }
    }
}