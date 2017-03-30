using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CHXDatabaseLibrary.QueryConverter;
using CHXDatabase;
using CHXDatabase.IO;
using CHXDatabase.IO.DatabaseFeatures;

namespace CHXDatabaseLibrary
{
    public class CHXDatabaseManager: ICHXDatabaseManager
    {
        CHXDatabase.IO.CHXDatabase _database;
        CHXTableCollection _tables;
        CHXTableCollection _views;
        CHXSequenceCollection _sequences;
        ICHXCommandManager _commandManager;
        CHXGeometryColumns _geometryColumnCollection;
        CHXConstraintCollection _constraints;
        CHXIndexCollection _indexes;


        public override ICHXCommandManager CommandManager
        {
            get
            {
                return _commandManager;
            }
        }

        public override CHXDatabase.IO.CHXDatabase Database
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

        public override CHXTableCollection Tables
        {
            get
            {
                if(_tables == null)
                {
                    _tables = new CHXTableCollection();

                    _tables.AddRange(this.RunQuery<CHXTable>(CommandManager.Commands.GetAllTable()));
                    _tables.ForEach(t => t.SetDatabaseManager(this));
                }

                return _tables;
            }
        }

        public override CHXGeometryColumns GeometryColumnCollection
        {
            get
            {
                return _geometryColumnCollection;
            }
        }

        public override CHXTableCollection Views
        {
            get
            {
                if (_views == null)
                {
                    _views = new CHXTableCollection();

                    _views.AddRange(this.RunQuery<CHXTable>(CommandManager.Commands.GetAllView()));
                    _views.ForEach(t => t.SetDatabaseManager(this));
                    _views.ForEach(t => t.IsView = true);
                }

                return _views;
            }
        }

        public override CHXSequenceCollection Sequences
        {
            get
            {
                if (_sequences == null)
                {
                    _sequences = new CHXSequenceCollection();

                    _sequences.AddRange(this.RunQuery<CHXSequence>(CommandManager.Commands.GetAllSequence()));
                    _sequences.ForEach(t => t.SetDatabaseManager(this));
                }

                return _sequences;
            }
        }

        public override CHXConstraintCollection Constraints
        {
            get
            {
                if (_constraints == null)
                {
                    _constraints = new CHXConstraintCollection();

                    _constraints.AddRange(this.RunQuery<CHXConstraint>(CommandManager.Commands.GetAllConstraint()));
                    _constraints.ForEach(c => c.SetDatabaseManager(this));
                    _constraints.ForEach(c => c.ConstraintType = CommandManager.Commands.GetConstraintType(c));
                }

                return _constraints;
            }
        }

        public override CHXIndexCollection Indexes
        {
            get
            {
                if (_indexes == null)
                {
                    _indexes = new CHXIndexCollection();
                    _indexes.AddRange(this.RunQuery<CHXIndex>(CommandManager.Commands.GetAllIndex()));
                    _indexes.ForEach(c => c.SetDatabaseManager(this));
                }

                return _indexes;
            }
        }

        public override bool Status
        {
            get
            {
                return Database.Connection.Status;
            }
        }

        public override string Version
        {
            get
            {
                return this.Database.Connection.Version;
            }
        }

        public CHXDatabaseManager()
        {

        }

        public CHXDatabaseManager(CHXDatabase.IO.CHXDatabase database)
        {
            _database = database;

            _database.SetConnection(CHXDatabaseFactory.GetDatabase(_database.ConnectionParameters, _database.DatabaseType, _database));

            _database.DatabaseManager = this;

            Init();
        }

        protected void Init()
        {
            _tables = null;
            _commandManager = new CHXCommandManager(_database);

            

            LoadGeometryColumnsContainer();
        }

        public override void LoadGeometryColumnsContainer()
        {
            _geometryColumnCollection = null;
            _geometryColumnCollection = new CHXGeometryColumns();
            _geometryColumnCollection.AddRange(this.RunQuery<CHXGeometryColumn>(CommandManager.Commands.GetAllGeometryColumns()));
        }

        public override IEnumerable<T> RunQuery<T>(CHXQuery query)
        {
            var result = Database.Connection.RunQuery<T>(query);

            

            return result;
        }

        public override IEnumerable<T> RunQuery<T>(QueryContainer queryContainer)
        {
            if (queryContainer.Database.DatabaseType != this.Database.DatabaseType) throw new Exception("Hedef veri tabanı tipi ve sorgu veri tabanı tipi uyumsuz.");

            var query = new CHXQuery();
            query.Sql = queryContainer.Sql;
            query.Parameter = queryContainer.Parameter;
            query.AddGeometry = queryContainer.AddGeometry;
            query.GeometryColumn = queryContainer.GeometryColumn;
            


            return this.RunQuery<T>(query);
        }

        public override QueryContainer ConvertQuery<T>(T data, CHXQueryType queryType)
        {
            var converter = QueryConverter.CHXQueryConverterFactory.GetQueryConverter(queryType);

            if (converter == null) throw new Exception("geçerli bir query type değil");

            var result = converter.Convert<T>(data);

            if (result.AddGeometry) result.GeometryColumn = Tables.Find(t => t.TableName == result.GeometryTable && t.SchemaName == result.GeometryTableSchema).GeometryColumn.Name;

            result.Database = this.Database;

            return result;
        }

    }
}
