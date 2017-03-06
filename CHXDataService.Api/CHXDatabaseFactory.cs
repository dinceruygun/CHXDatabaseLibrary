using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api
{
    public static class CHXDatabaseFactory
    {
        private static object _locker = new object();
        private static CHXDatabaseCollection _databaseCollection;

        public static CHXDatabaseCollection DatabaseCollection
        {
            get
            {
                if (_databaseCollection == null)
                {
                    lock (_locker)
                    {
                        if (_databaseCollection == null)
                        {
                            _databaseCollection = new CHXDatabaseCollection();
                        }
                    }
                }

                return _databaseCollection;
            }
        }

        static CHXDatabaseFactory()
        {
            var parameters = new CHXDatabaseLibrary.CHXDatabaseParameters();

            parameters.Add("Server", "192.168.2.188");
            parameters.Add("Port", "5432");
            parameters.Add("Database", "kbb_test");
            parameters.Add("User Id", "postgres");
            parameters.Add("Password", "ntc123*");


            DatabaseCollection.Add("test", parameters, CHXDatabaseLibrary.CHXDatabaseType.PostgreSql);
        }

        public static CHXDatabaseContainer GetDatabase(string databaseName)
        {
            if (string.IsNullOrEmpty(databaseName)) return null;

            return DatabaseCollection[databaseName];
        }
    }
}
