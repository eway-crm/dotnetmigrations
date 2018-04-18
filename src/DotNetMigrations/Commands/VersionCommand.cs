﻿using System;
using System.Linq;
using DotNetMigrations.Core;
using DotNetMigrations.Migrations;

namespace DotNetMigrations.Commands
{
    public class VersionCommand : DatabaseCommandBase<DatabaseCommandArguments>
    {
        private readonly IMigrationDirectory _migrationDirectory;

        public VersionCommand()
            : this(new MigrationDirectory())
        {
        }

        public VersionCommand(IMigrationDirectory migrationDirectory)
        {
            _migrationDirectory = migrationDirectory;
        }

        /// <summary>
        /// The name of the command that is typed as a command line argument.
        /// </summary>
        public override string CommandName
        {
            get { return "version"; }
        }

        /// <summary>
        /// The help text information for the command.
        /// </summary>
        public override string Description
        {
            get { return "Displays the latest version of the database and the migration scripts."; }
        }

        /// <summary>
        /// Executes the Command's logic.
        /// </summary>
        protected override void Execute(DatabaseCommandArguments args)
        {
            // Obtain Latest Script Version
            long scriptVersion = GetLatestScriptVersion(args);

            // Obtain Latest Database Version
            long databaseVersion = GetDatabaseVersion();

            Log.WriteLine("Database is at version:".PadRight(30) + databaseVersion);
            Log.WriteLine("Scripts are at version:".PadRight(30) + scriptVersion);

            if (databaseVersion == scriptVersion)
            {
                Log.WriteLine(string.Empty);
                Log.WriteLine("Your database is up-to-date!");
            }
        }

        /// <summary>
        /// Retrieves the latest migration script version from the migration directory.
        /// </summary>
        /// <returns>The latest script version</returns>
        private long GetLatestScriptVersion(DatabaseCommandArguments args)
        {
            IOrderedEnumerable<IMigrationScriptFile> files = _migrationDirectory.GetScripts(args)
                .OrderByDescending(x => x.Version);

            IMigrationScriptFile latestFile = files.FirstOrDefault();

            if (latestFile != null)
            {
                return latestFile.Version;
            }

            return 0;
        }
    }
}