
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary
{
    public class CHXDatabase: ICHXDatabase
    {
        CHXDatabaseParameters _connectionParameters;
        CHXDatabaseType? _databaseType;
        CHXDatabaseConnection _connection;



        public CHXDatabaseParameters ConnectionParameters
        {
            get
            {
                return _connectionParameters;
            }
        }

        public CHXDatabaseType? DatabaseType
        {
            get
            {
                return _databaseType;
            }
        }

        public CHXDatabaseConnection Connection
        {
            get
            {
                return _connection;
            }
        }

        public CHXDatabase()
        {

        }

        public CHXDatabase(CHXDatabaseParameters connectionParameters, CHXDatabaseType? databaseType)
        {
            checkParameters(connectionParameters, databaseType);

            _connectionParameters = connectionParameters;
            _databaseType = databaseType;

            init();
        }

        protected bool checkParameters(CHXDatabaseParameters connectionParameters, CHXDatabaseType? databaseType)
        {
            if (connectionParameters == null || databaseType == null)
            {
                throw new NullReferenceException("veri tabanı parametreleri ya da veri tabanı türü boş geçilemez.");
            }
            else
            {
                return true;
            }
        }

        protected void init()
        {
            _connection = CHXDatabaseFactory.GetDatabase(ConnectionParameters, DatabaseType, this);
        }

    }
}
