using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO.DatabaseFeatures
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXSequence: ICHXDatabaseFeature
    {
        string _schemaName;
        string _tableName;
        string _columnName;
        string _sequenceName;
        string _maximumValue;
        string _minimumValue;
        string _startValue;
        string _currentValue;



        public string StartValue
        {
            get
            {
                return _startValue;
            }

            set
            {
                _startValue = value;
            }
        }

        public string MinimumValue
        {
            get
            {
                return _minimumValue;
            }

            set
            {
                _minimumValue = value;
            }
        }

        public string MaximumValue
        {
            get
            {
                return _maximumValue;
            }

            set
            {
                _maximumValue = value;
            }
        }

        public string SequenceName
        {
            get
            {
                return _sequenceName;
            }

            set
            {
                _sequenceName = value;
            }
        }

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
                return base.DatabaseManager.Tables.Find(t => t.TableName == this.TableName);
            }
        }

        public string CurrentValue
        {
            get
            {
                if (_currentValue == null)
                {
                    var seq = base.DatabaseManager.RunQuery<CHXSequence>(base.DatabaseManager.CommandManager.Commands.GetSequence(this.SequenceName)).FirstOrDefault();
                    _currentValue = seq.CurrentValue;
                }

                return _currentValue;
            }

            set {
                _currentValue = value;
            }
        }


        public override string ToString()
        {
            return $"{SchemaName}.{SequenceName}";
        }
    }
}
