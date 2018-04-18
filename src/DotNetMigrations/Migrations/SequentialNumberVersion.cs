﻿using System;
using System.Collections.Generic;
using System.Linq;
using DotNetMigrations.Core;

namespace DotNetMigrations.Migrations
{
    public class SequentialNumberVersion : IVersionStrategy
    {
        #region IVersionStrategy Members

        public long GetNewVersionNumber(IMigrationDirectory migrationDirectory, IScriptsDirectoryPathArgs args)
        {
            long lastNumber = 0;

            // get the latest number in use
            IEnumerable<IMigrationScriptFile> scripts = migrationDirectory.GetScripts(args);

            if (scripts.Count() > 0)
            {
                lastNumber = scripts.Max(script => script.Version);
            }

            // increment and return
            return lastNumber + 1;
        }

        #endregion
    }
}