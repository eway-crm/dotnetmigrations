using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using DotNetMigrations.Core;

namespace DotNetMigrations.Commands
{
    public class GenerateScriptCommandArgs : CommandArguments, IScriptsDirectoryPathArgs
    {
        [Required(ErrorMessage = "-name is required")]
        [Argument("name", "n", "Name of the migration script to generate",
            Position = 1,
            ValueName = "migration_name")]
        public string MigrationName { get; set; }

        [Argument("scriptsDirectoryPath", "scriptsDir", "The directory where the migration scripts are located.")]
        public string ScriptsDirectoryPath { get; set; }
    }
}