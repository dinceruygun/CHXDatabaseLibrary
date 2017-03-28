using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO.DatabaseFeatures
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXIndex: ICHXDatabaseFeature
    {
        string _schemaName;
        string _tableName;
        string _indexName;
        bool _isUnique;
        string _columnName;
        

        public string ColumnName
        {
            get
            {
                return _columnName;
            }

            set
            {
                _columnName = value;
            }
        }

        public bool IsUnique
        {
            get
            {
                return _isUnique;
            }

            set
            {
                _isUnique = value;
            }
        }

        public string IndexName
        {
            get
            {
                return _indexName;
            }

            set
            {
                _indexName = value;
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

        public string SchemaName
        {
            get
            {
                return _schemaName;
            }

            set
            {
                _schemaName = value;
            }
        }

        public CHXTable Table
        {
            get
            {
                return base.DatabaseManager.Tables.Find(t => t.TableName == this.TableName && t.SchemaName == this.SchemaName);
            }
        }


        public override string ToString()
        {
            return $"{this.SchemaName}.{this.TableName}.{this.IndexName}";
        }
    }
}
