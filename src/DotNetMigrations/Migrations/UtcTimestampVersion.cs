using System;
using System.Linq;
using DotNetMigrations.Core;

namespace DotNetMigrations.Migrations
{
    public class UtcTimestampVersion : IVersionStrategy
    {
        public long GetNewVersionNumber(IMigrationDirectory migrationDirectory, IScriptsDirectoryPathArgs args)
        {
            var v = long.Parse(DateTime.UtcNow.ToString("yyyyMMddHHmmss"));
            return v;
        }
    }
}