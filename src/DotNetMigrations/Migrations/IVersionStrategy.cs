using System;
using System.Linq;
using DotNetMigrations.Core;

namespace DotNetMigrations.Migrations
{
    public interface IVersionStrategy
    {
        long GetNewVersionNumber(IMigrationDirectory migrationDirectory, IScriptsDirectoryPathArgs args);
    }
}