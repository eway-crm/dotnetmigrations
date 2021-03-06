using System;
using System.Linq;

namespace DotNetMigrations.Migrations
{
    public interface IMigrationScriptFile
    {
        string FilePath { get; }
        long Version { get; }

        MigrationScriptContents Read();
        void Write(MigrationScriptContents contents);
    }
}