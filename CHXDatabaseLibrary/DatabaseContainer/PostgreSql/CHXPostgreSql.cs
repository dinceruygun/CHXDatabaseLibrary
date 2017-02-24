using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.DatabaseContainer.PostgreSql
{
    public class CHXPostgreSql : CHXDatabaseConnection, IDbConnection
    {

        NpgsqlConnection _connection;
        string _versionPostgis;
        

        internal CHXPostgreSql(CHXDatabaseParameters connectionParameters, ICHXDatabase manager) : base(connectionParameters, manager)
        {
            
        }


        public override void Init()
        {
            _connection = new NpgsqlConnection(base.ConnectionParameters.ToString());
        }

        public NpgsqlConnection Connection
        {
            get
            {
                return _connection;
            }
        }

        public string ConnectionString
        {
            get
            {
                return _connection.ConnectionString;
            }

            set
            {
                _connection.ConnectionString = value;
            }
        }

        public int ConnectionTimeout
        {
            get
            {
                return _connection.ConnectionTimeout;
            }
        }

        public string Database
        {
            get
            {
                return _connection.Database;
            }
        }

        public ConnectionState State
        {
            get
            {
                return _connection.State;
            }
        }

        public string VersionPostgis
        {
            get
            {
                return _versionPostgis;
            }

            set
            {
                _versionPostgis = value;
            }
        }


        public IDbTransaction BeginTransaction()
        {
            return _connection.BeginTransaction();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return _connection.BeginTransaction(il);
        }

        public void ChangeDatabase(string databaseName)
        {
            _connection.ChangeDatabase(databaseName);
        }

        public void Close()
        {
            _connection.Close();
        }

        public IDbCommand CreateCommand()
        {
            return _connection.CreateCommand();
        }

        public void Dispose()
        {
            _connection = null;
        }

        public void Open()
        {
            _connection.Open();
        }

        public override void LoadVersion()
        {
            base.Version = this.Query<string>("SHOW server_version;").FirstOrDefault().ToString();

            VersionPostgis = this.Query<string>("SELECT extversion FROM pg_catalog.pg_extension WHERE extname='postgis';")?.FirstOrDefault()?.ToString();
        }

        public override bool CheckSpatial()
        {
            return (VersionPostgis == null) ? false : true;
        }

        public override IEnumerable<T> RunQuery<T>(CHXQuery query)
        {
            return Connection.Query<T>(query.Sql, query.Parameter, query.Transaction, query.Buffered, query.CommandTimeout, query.CommandType);
        }
    }
}
