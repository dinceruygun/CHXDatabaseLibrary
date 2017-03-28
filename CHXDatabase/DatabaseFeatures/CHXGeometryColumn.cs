using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO.DatabaseFeatures
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXGeometryColumn: ICHXDatabaseFeature
    {
        string _catalogName;
        string _schemaName;
        string _tableName;
        string _geometryColumn;
        string _srid;
        string _geometryType;

        public string GeometryType
        {
            get
            {
                return _geometryType;
            }

            set
            {
                _geometryType = value;
            }
        }

        public string SRID
        {
            get
            {
                return _srid;
            }

            set
            {
                _srid = value;
            }
        }

        public string Name
        {
            get
            {
                return _geometryColumn;
            }

            set
            {
                _geometryColumn = value;
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

        public string CatalogName
        {
            get
            {
                return _catalogName;
            }

            set
            {
                _catalogName = value;
            }
        }


        public override string ToString()
        {
            return $"{this.SchemaName}.{this.TableName}.{this.Name} (SRID:{this.SRID})";
        }
    }
}
