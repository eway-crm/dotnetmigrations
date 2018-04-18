using System;
using System.Collections.Generic;
using System.Linq;
using DotNetMigrations.Core;
using DotNetMigrations.Commands;

namespace DotNetMigrations.Migrations
{
    public interface IMigrationDirectory
    {
        /// <summary>
        /// Returns the migration script path from the
        /// config file (if available) or the default path.
        /// </summary>
        string GetPath(ILogger log, IScriptsDirectoryPathArgs args);

        /// <summary>
        /// Returns a list of all the migration script file paths
        /// sorted by version number (ascending).
        /// </summary>
        IEnumerable<IMigrationScriptFile> GetScripts(IScriptsDirectoryPathArgs args);

        /// <summary>
        /// Creates a blank migration script with the given name.
        /// </summary>
        /// <returns>The path to the new migration script.</returns>
        string CreateBlankScript(GenerateScriptCommandArgs args);
    }
}