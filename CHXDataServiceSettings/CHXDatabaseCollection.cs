﻿using CHXDatabaseLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXDataServiceSettings
{
    public class CHXDatabaseCollection: ICollection
    {
        private List<CHXDatabaseContainer> databaseList;




        public CHXDatabaseCollection()
        {
            databaseList = new List<CHXDatabaseContainer>();
        }

        public CHXDatabaseContainer this[int index]
        {
            get
            {
                return databaseList[index];
            }
        }



        public CHXDatabaseContainer this[string databaseName]
        {
            get
            {
                return databaseList.Where(d => d.Name == databaseName).FirstOrDefault();
            }
        }


        public void Add(CHXDatabaseContainer database)
        {
            if (database == null) return;

            if (this[database.Name] == null)
            { 
                databaseList.Add(database);
            }
        }


        public CHXDatabaseContainer Add(string databaseName, CHXDatabaseParameters connectionParameters, CHXDatabaseType databaseType)
        {
            CHXDatabaseContainer db = null;

            if (this[databaseName] == null)
            {
                db = new CHXDatabaseContainer() { Name = databaseName };
                db.Database = new CHXDatabaseManager(new CHXDatabase.IO.CHXDatabase(connectionParameters, databaseType));

                this.Add(db);
            }

            return db;
        }


        public CHXDatabaseContainer Add(string databaseName)
        {
            CHXDatabaseContainer db = null;

            if (this[databaseName] == null)
            {
                db = new CHXDatabaseContainer() { Name = databaseName };

                this.Add(db);
            }

            return db;
        }


        public int Count
        {
            get
            {
                return databaseList.Count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public List<CHXDatabaseContainer> DatabaseList
        {
            get
            {
                return databaseList;
            }

            set
            {
                databaseList = value;
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            return databaseList.GetEnumerator();
        }
    }




    public class CHXDatabaseContainer
    {
        CHXDatabaseManager _database;
        string _name;

        public CHXDatabaseManager Database
        {
            get
            {
                return _database;
            }

            set
            {
                _database = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public QueryContainer ConvertQuery<T>(T data, CHXQueryType queryType)
        {
            return this.Database.ConvertQuery <T> (data, CHXQueryType.Json);
        }

        public IEnumerable<T> RunQuery<T>(object query)
        {
            if (!(query is QueryContainer)) return null;

            return this.Database.RunQuery<T>((query as QueryContainer));
        }
    }
}
