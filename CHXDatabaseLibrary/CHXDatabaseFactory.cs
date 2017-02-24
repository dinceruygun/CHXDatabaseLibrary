using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary
{
    public static class CHXDatabaseFactory
    {
        private static object _locker = new object();

        internal static CHXDatabaseConnection GetDatabase(CHXDatabaseParameters connectionParameters, CHXDatabaseType? databaseType, ICHXDatabase manager)
        {
            lock (_locker)
            {
                switch (databaseType)
                {
                    case CHXDatabaseType.PostgreSql:
                        return new DatabaseContainer.PostgreSql.CHXPostgreSql(connectionParameters, manager);
                    default:
                        return null;
                }
            }
        }
    }
}
