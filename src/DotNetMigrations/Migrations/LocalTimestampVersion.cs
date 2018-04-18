using System;
using DotNetMigrations.Core;

namespace DotNetMigrations.Migrations
{
    public class LocalTimestampVersion : IVersionStrategy
    {
        public long GetNewVersionNumber(IMigrationDirectory migrationDirectory, IScriptsDirectoryPathArgs args)
        {
            var v = long.Parse(DateTime.Now.ToString("yyyyMMddHHmmss"));
            return v;
        }
    }
}