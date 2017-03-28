using CHXDatabaseLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using CHXConverter;
using CHXDatabase;
using CHXDatabase.IO;

namespace CHXDataService.Api
{
    public class CHXDatabaseSettingsList : List<CHXDatabaseSettings> { }

    public class CHXDatabaseSettings
    {
        public string name { get; set; }
        public CHXDatabaseParameters parameters { get; set; }
        public CHXDatabaseType? type { get; set; }
    }

    public static class CHXDatabaseFactory
    {
        private static object _locker = new object();

        public static void DeleteDatabase(string name)
        {
            lock (_locker)
            {
                _databaseCollection.DatabaseList.Remove(_databaseCollection.DatabaseList.Find(d => d.Name == name));
            }
        }

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
            _databaseCollection = new CHXDatabaseCollection();

            var settings = CHXSettings.CHXSettingsManager.Get("databaselist");

            if (settings == null) return;

            var convertList = JsonConvert.DeserializeObject<CHXDatabaseSettingsList>(settings);

            foreach (var item in convertList)
            {
                _databaseCollection.Add(new CHXDatabaseContainer() { Name = item.name, Database = new CHXDatabaseManager(new CHXDatabase.IO.CHXDatabase(item.parameters, item.type)) });
            }

        }

        private static void Save()
        {
            var data = JsonConvert.SerializeObject(DatabaseCollection.DatabaseList.Select(d =>
                        new CHXDatabaseSettings()
                        {
                            name = d.Name,
                            parameters = d.Database.Database.ConnectionParameters,
                            type = d.Database.Database.DatabaseType
                        }));


            CHXSettings.CHXSettingsManager.Set("databaselist", data);
        }


        public static void AddDatabase(string databaseName, CHXDatabaseParameters connectionParameters, CHXDatabaseType databaseType)
        {
            lock (_locker)
            {
                var db = new CHXDatabaseContainer() { Name = databaseName };
                db.Database = new CHXDatabaseManager(new CHXDatabase.IO.CHXDatabase(connectionParameters, databaseType));

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

            var parameters = new CHXDatabaseParameters();

            parameters.Add("Server", "192.168.2.188");
            parameters.Add("Port", "5432");
            parameters.Add("Database", "kbb_test");
            parameters.Add("User Id", "postgres");
            parameters.Add("Password", "ntc123*");


            DatabaseCollection.Add("test", parameters, CHXDatabaseType.PostgreSql);
        }

        public static CHXDatabaseContainer GetDatabase(string databaseName)
        {
            if (string.IsNullOrEmpty(databaseName)) return null;

            return DatabaseCollection[databaseName];
        }
    }



   
}
