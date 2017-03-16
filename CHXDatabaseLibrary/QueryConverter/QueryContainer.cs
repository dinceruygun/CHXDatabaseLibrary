using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter
{
    public class QueryContainer
    {
        public string Server { get; set; }
        public string Schema { get; set; }
        public QueryCollection Query { get; set; }

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



    public class QueryFindList : List<QueryFind> { }

    public class QueryFind
    {
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


        public QueryFind()
        {

        }

        public QueryFind(string name, object value)
        {
            _name = name;
            _value = value;
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
}
