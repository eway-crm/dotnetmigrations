using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace DotNetMigrations.Core
{
    public class DatabaseCommandArguments : CommandArguments, IScriptsDirectoryPathArgs
    {
        [Required(ErrorMessage = "-connection is required")]
        [Argument("connection", "c", "Connection string to use, or the name of the connection from app.config to use.",
            Position = 1)]
        public string Connection { get; set; }

        [Argument("scriptsDirectoryPath", "scriptsDir", "The directory where the migration scripts are located.")]
        public string ScriptsDirectoryPath { get; set; }
    }
}