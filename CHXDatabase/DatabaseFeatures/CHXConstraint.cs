using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO.DatabaseFeatures
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXConstraint: ICHXDatabaseFeature
    {
        CHXConstraintType _constraintType;
        string _schemaName;
        string _tableName;
        string _constraintName;
        string _constraintValue;


        public CHXConstraintType ConstraintType
        {
            get
            {
                return _constraintType;
            }

            set
            {
                _constraintType = value;
            }
        }

        public string ConstraintValue
        {
            get
            {
                return _constraintValue;
            }

            set
            {
                _constraintValue = value;
            }
        }

        public string ConstraintName
        {
            get
            {
                return _constraintName;
            }

            set
            {
                _constraintName = value;
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
            return $"{this.SchemaName}.{this.TableName}.{this.ConstraintName}";
        }

    }
}
