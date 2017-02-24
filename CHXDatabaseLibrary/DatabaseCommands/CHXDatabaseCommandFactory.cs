using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.DatabaseCommands
{
    public static class CHXDatabaseCommandFactory
    {
        private static object _locker = new object();

        public static ICHXDatabaseCommand GetDatabaseCommand(CHXDatabase database)
        {
            lock (_locker)
            {
                switch (database.DatabaseType)
                {
                    case CHXDatabaseType.PostgreSql:
                        return new PostgreSql.PostgreSql(database);
                    default:
                        return null;
                }
            }
        }
    }
}
