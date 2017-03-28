using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase;
using CHXDatabase.IO;
using CHXPostgreSqlLibrary;

namespace CHXDatabaseLibrary
{
    public static class CHXDatabaseCommandFactory
    {
        private static object _locker = new object();

        public static ICHXDatabaseCommand GetDatabaseCommand(CHXDatabase.IO.CHXDatabase database)
        {
            lock (_locker)
            {
                switch (database.DatabaseType)
                {
                    case CHXDatabaseType.PostgreSql:
                        return new CHXPostgreSqlCommans(database);
                    default:
                        return null;
                }
            }
        }
    }
}
