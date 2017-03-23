using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabaseLibrary.DatabaseFeatures;
using System.Data;
using CHXDatabaseLibrary.QueryConverter;

namespace CHXDatabaseLibrary
{
    public class CHXDatabaseManager
    {
        CHXDatabase _database;
        DatabaseFeatures.CHXTableCollection _tables;
        DatabaseFeatures.CHXTableCollection _views;
        DatabaseFeatures.CHXSequenceCollection _sequences;
        CHXCommandManager _commandManager;
        CHXGeometryColumns _geometryColumnCollection;
        CHXConstraintCollection _constraints;
        CHXIndexCollection _indexes;


        public CHXCommandManager CommandManager
        {
            get
            {
                return _commandManager;
            }
        }


        public CHXDatabase Database
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

        

        public CHXTableCollection Tables
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

        public CHXGeometryColumns GeometryColumnCollection
        {
            get
            {
                return _geometryColumnCollection;
            }
        }

        public CHXTableCollection Views
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

        public CHXSequenceCollection Sequences
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

        public CHXConstraintCollection Constraints
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

        public CHXIndexCollection Indexes
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

        public CHXDatabaseManager()
        {

        }

        public CHXDatabaseManager(CHXDatabase database)
        {
            _database = database;
            _database.DatabaseManager = this;

            Init();
        }

        protected void Init()
        {
            _tables = null;
            _commandManager = new CHXCommandManager(_database);

            LoadGeometryColumnsContainer();
        }

        protected void LoadGeometryColumnsContainer()
        {
            _geometryColumnCollection = null;
            _geometryColumnCollection = new CHXGeometryColumns();
            _geometryColumnCollection.AddRange(this.RunQuery<DatabaseFeatures.CHXGeometryColumn>(CommandManager.Commands.GetAllGeometryColumns()));
        }

        public IEnumerable<T> RunQuery<T>(CHXQuery query)
        {
            var result = Database.Connection.RunQuery<T>(query);

            

            return result;
        }


        public IEnumerable<T> RunQuery<T>(QueryContainer queryContainer)
        {
            if (queryContainer.Database.DatabaseType != this.Database.DatabaseType) throw new Exception("Hedef veri tabanı tipi ve sorgu veri tabanı tipi uyumsuz.");

            var query = new CHXQuery();
            query.Sql = queryContainer.Sql;
            query.Parameter = queryContainer.Parameter;
            query.AddGeometry = queryContainer.AddGeometry;
            query.GeometryColumn = queryContainer.GeometryColumn;
            


            return this.RunQuery<T>(query);
        }


        public QueryContainer ConvertQuery<T>(T data, CHXQueryType queryType)
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
