using CHXDatabaseLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
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

        private static void Load()
        {
            //DatabaseCollection = JsonConvert.DeserializeObject<CHXDatabaseCollection>("");
        }

        private static void Save()
        {
            var data = JsonConvert.SerializeObject(DatabaseCollection.DatabaseList.Select(d =>
                        new
                        {
                            name = d.Name,
                            parameters = d.Database.Database.ConnectionParameters,
                            type = d.Database.Database.DatabaseType
                        }), Formatting.None,
                        new JsonSerializerSettings()
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        });


            IResourceWriter writer = new ResourceWriter("CHXDataService.Api.CHXSettings");
            writer.AddResource("CHXDatabaseList", data);
            writer.Generate();
            writer.Close();
        }


        public static void AddDatabase(string databaseName, CHXDatabaseParameters connectionParameters, CHXDatabaseType databaseType)
        {
            lock (_locker)
            {
                var db = new CHXDatabaseContainer() { Name = databaseName };
                db.Database = new CHXDatabaseManager(new CHXDatabase(connectionParameters, databaseType));

                AddDatabase(db);
            }
        }


        public static void AddDatabase(CHXDatabaseContainer database)
        {
            lock (_locker)
            {
                DatabaseCollection.Add(database);
                Save();
            }
        }

        static CHXDatabaseFactory()
        {
            Load();


            return;

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
