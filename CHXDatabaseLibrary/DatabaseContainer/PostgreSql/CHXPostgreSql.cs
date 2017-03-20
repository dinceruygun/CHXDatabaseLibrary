using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabaseLibrary.QueryConverter;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;

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
            var result = Connection.Query<T>(query.Sql, query.Parameter, query.Transaction, query.Buffered, query.CommandTimeout, query.CommandType);

            var pgconverter = PgDataConverterFactory.GetConverter(typeof(T).Name);

            if(pgconverter == null)
            {
                return result;
            }
            else
            {
                return pgconverter.Convert<T>(query, result);
            }

        }

        public override string ToSql(QueryContainer queryContainer, bool addParameter)
        {
            var fields = new StringBuilder();
            string firstTable = null;
            var join = new StringBuilder();
            var where = new StringBuilder();
            var group = new StringBuilder();
            
            if (queryContainer == null) return null;
            if (queryContainer.Query == null) return null;

            foreach (var q in queryContainer.Query)
            {
                if (fields.Length > 0) fields.Append(", ");

                fields.Append(string.Join(", ", q.Field.Select(f => f.Alias == null ? $"{q.TableName}.{f.Name}" : $"{q.TableName}.{f.Name} as {f.Alias}").ToArray()));

                if (q.AddGeometry)
                {
                    var table = this.DatabaseManager.Tables.Find(t => t.TableName == q.TableName && t.SchemaName == queryContainer.Schema);
                    if (table.IsSpatial && table.GeometryColumn != null)
                    {
                        fields.Append($", st_astext({table.GeometryColumn.Name}) as {table.GeometryColumn.Name}");
                        //fields.Append($", st_asgeojson({table.GeometryColumn.Name}) as {table.GeometryColumn.Name}");
                    }
                }


                if (string.IsNullOrEmpty(firstTable)) firstTable = q.TableName;


                if (where.Length > 0 && q.QueryFind != null)
                    if (q.QueryFind.Count > 0)
                        where.Append(" and ");

                where.Append(string.Join(" or ", q.QueryFind.Select(
                    f =>
                    "(" + string.Join(" and ", f.Select(
                        c =>
                            addParameter == true ? $"{q.TableName}.{c.Name} = {c.Value}" :
                            $"{q.TableName}.{c.Name} = @{c.Name}{c.Id}"
                        )
                        ) + ")"
                        )));
            }


            if (queryContainer.Join != null)
            {
                foreach (var j in queryContainer.Join)
                {
                    switch (j.joinType)
                    {
                        case JoinType.INNER:
                            join.Append(" inner join ");
                            break;
                        case JoinType.LEFT:
                            join.Append(" left join ");
                            break;
                        case JoinType.RIGHT:
                            join.Append(" right join ");
                            break;
                        default:
                            break;
                    }


                    join.Append(j.Destination.Split('.')[0]);
                    join.Append(" on ");
                    join.Append(j.Destination);
                    join.Append(" = ");
                    join.Append(j.Target);
                }
            }



            if (queryContainer.Group != null)
            {
                if (queryContainer.Group.Count > 0)
                {
                    group.Append(" group by ");
                    group.Append(string.Join(", ", queryContainer.Group.Select(g => g.ToString()).ToArray()));
                }
            }


            var sql = $"select {fields.ToString()} from {firstTable} {join.ToString()} where {where.ToString()} {group}";


            return sql;
        }

        public override object ToParameter(QueryContainer queryContainer)
        {
            var dbArgs = new DynamicParameters();

            foreach (var q in queryContainer.Query)
            {
                foreach (var p in q.QueryFind)
                {
                    foreach (var v in p)
                    {
                        dbArgs.Add($"{v.Name}{v.Id}", v.Value);
                    }
                }
            }

            return dbArgs;
        }
    }
}
