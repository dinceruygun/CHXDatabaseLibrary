using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.DatabaseFeatures
{
    [DebuggerDisplay("{ToString()}")]
    public class CHXColumn: ICHXDatabaseFeature
    {
        string _columnName;
        string _defaultValue;
        string _isNullable;
        string _dataType;
        string _maximumLength;
        CHXSequence _sequence;
        CHXIndexCollection _indexes;
        CHXTable _table;

        public string MaximumLength
        {
            get
            {
                return _maximumLength;
            }

            set
            {
                _maximumLength = value;
            }
        }

        public string DataType
        {
            get
            {
                return _dataType;
            }

            set
            {
                _dataType = value;
            }
        }

        public string IsNullable
        {
            get
            {
                return _isNullable;
            }

            set
            {
                _isNullable = value;
            }
        }

        public string DefaultValue
        {
            get
            {
                return _defaultValue;
            }

            set
            {
                _defaultValue = value;
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

        public CHXSequence Sequence
        {
            get
            {
                if (_sequence == null)
                {
                    _sequence = this.Table.Sequences.Find(s => s.ColumnName == this.ColumnName);
                }

                return _sequence;
            }
        }

        public CHXTable Table
        {
            get
            {
                return _table;
            }

            set
            {
                _table = value;
            }
        }

        public CHXIndexCollection Indexes
        {
            get
            {
                if (_indexes == null)
                {
                    _indexes = new CHXIndexCollection();

                    _indexes.AddRange(this.Table.Indexes.Where(i => i.ColumnName == this.ColumnName));
                }

                return _indexes;
            }
        }

        public override string ToString()
        {
            return ColumnName;
        }
    }
}
