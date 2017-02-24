using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary
{

    [DebuggerDisplay("{ToString()}")]
    public class CHXQuery
    {

        string _sql;
        object _parameter;
        IDbTransaction _transaction;
        bool _buffered;
        int? _commandTimeout;
        CommandType? _commandType;
        string _queryName;



        public string Sql
        {
            get
            {
                return _sql;
            }

            set
            {
                _sql = value;
            }
        }

        public object Parameter
        {
            get
            {
                return _parameter;
            }

            set
            {
                _parameter = value;
            }
        }

        public IDbTransaction Transaction
        {
            get
            {
                return _transaction;
            }

            set
            {
                _transaction = value;
            }
        }

        public bool Buffered
        {
            get
            {
                return _buffered;
            }

            set
            {
                _buffered = value;
            }
        }

        public CommandType? CommandType
        {
            get
            {
                return _commandType;
            }

            set
            {
                _commandType = value;
            }
        }

        public int? CommandTimeout
        {
            get
            {
                return _commandTimeout;
            }

            set
            {
                _commandTimeout = value;
            }
        }

        public string QueryName
        {
            get
            {
                return _queryName;
            }

            set
            {
                _queryName = value;
            }
        }

        public CHXQuery()
        {

        }


        public CHXQuery(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = default(int?), CommandType? commandType = default(CommandType?))
        {
            Sql = sql;
            Parameter = param;
            Transaction = transaction;
            Buffered = buffered;
            CommandTimeout = commandTimeout;
            CommandType = commandType;
        }

        public override string ToString()
        {
            return Sql;
        }

    }
}
