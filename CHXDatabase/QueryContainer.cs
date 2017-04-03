using CHXGeoJson;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO
{
    public class QueryContainer
    {
        private string _sql;

        public string Server { get; set; }
        public string Schema { get; set; }
        public bool CountOnly { get; set; }
        public int Limit { get; set; }
        public QueryCollection Query { get; set; }
        public List<QueryJoin> Join { get; set; }
        public List<string> Group { get; set; }
        object _parameter;
        public bool AddGeometry { get; set; }
        public string GeometryTable { get; set; }
        public string GeometryColumn { get; set; }
        public string GeometryTableSchema { get; set; }


        public string Sql
        {
            get
            {
                if (_sql == null)
                {
                    _sql = this.Database.Connection.ToSql(this, false);
                }

                return _sql;
            }
        }

        public CHXDatabase Database { get; set; }

        public object Parameter
        {
            get
            {
                if (_parameter == null)
                {
                    _parameter = this.Database.Connection.ToParameter(this);
                }

                return _parameter;
            }
        }
    }



    [DebuggerDisplay("{ToString()}")]
    public class QueryJoin
    {
        public JoinType joinType { get; set; }
        public string Destination { get; set; }
        public string Target { get; set; }

        public override string ToString()
        {
            return $"{Destination}={Target}";
        }
    }


    [DebuggerDisplay("{ToString()}")]
    public class QueryTable
    {
        string _tableName;
        string _queryType;
        bool _addGeometry;
        List<QueryField> _field;
        List<QueryFindList> _queryFind;

        public List<QueryField> Field
        {
            get
            {
                return _field;
            }

            set
            {
                _field = value;
            }
        }

        public bool AddGeometry
        {
            get
            {
                return _addGeometry;
            }

            set
            {
                _addGeometry = value;
            }
        }

        public string QueryType
        {
            get
            {
                return _queryType;
            }

            set
            {
                _queryType = value;
            }
        }

        public string TableName
        {
            get
            {
                return _tableName;
            }

            set
            {
                _tableName = value;
            }
        }

        public List<QueryFindList> QueryFind
        {
            get
            {
                return _queryFind;
            }

            set
            {
                _queryFind = value;
            }
        }
        public List<QueryGeometry> QueryGeometryList { get; set; }

        public QueryTable()
        {
            _field = new List<QueryField>();
            _queryFind = new List<QueryFindList>();
        }


        public override string ToString()
        {
            return this.TableName;
        }
    }

    public class QueryGeometry
    {
        public double Distance { get; set; }
        public CHXGeometryRelation Relation { get; set; }
        public CHXGeometry Geometry { get; set; }
    }

    public class QueryFindList : List<QueryFind> { }

    [DebuggerDisplay("{ToString()}")]
    public class QueryFind
    {
        int _id;
        string _name;
        object _value;

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

        public object Value
        {
            get
            {
                return _value;
            }

            set
            {
                _value = value;
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public QueryFind()
        {

        }

        public QueryFind(string name, object value, int id)
        {
            _name = name;
            _value = value;

            _id = id;
        }

        public override string ToString()
        {
            return $"{this.Name}:{this.Value}";
        }

    }

    [DebuggerDisplay("{ToString()}")]
    public class QueryField
    {
        string _name;
        string _alias;

        public string Alias
        {
            get
            {
                return _alias;
            }

            set
            {
                _alias = value;
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

        public QueryField()
        {

        }

        public QueryField(string name)
        {
            _name = name;
        }


        public QueryField(string name, string alias)
        {
            _name = name;
            _alias = alias;
        }


        public override string ToString()
        {
            return this.Name;
        }
    }

    public class QueryCollection : List<QueryTable>
    {

    }


    public enum JoinType
    {
        INNER = 1,
        LEFT = 2,
        RIGHT = 3
    }
}
