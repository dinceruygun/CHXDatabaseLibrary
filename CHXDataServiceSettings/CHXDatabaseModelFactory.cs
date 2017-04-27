using CHXDatabaseLibrary;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CHXDatabase.IO;

namespace CHXDataServiceSettings
{
    public class CHXDatabaseSettingsList : List<CHXDatabaseSettings> { }

    public class CHXDatabaseSettings
    {
        public string name { get; set; }
        public CHXDatabaseParameters parameters { get; set; }
        public CHXDatabaseType? type { get; set; }
    }

    public static class CHXDatabaseModelFactory
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

        static CHXDatabaseModelFactory()
        {
            Load();
        }

        public static CHXDatabaseContainer GetDatabase(string databaseName)
        {
            if (string.IsNullOrEmpty(databaseName)) return null;

            return DatabaseCollection[databaseName];
        }
    }



   
}
