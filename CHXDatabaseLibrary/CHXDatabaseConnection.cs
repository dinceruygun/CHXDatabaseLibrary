using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabaseLibrary.QueryConverter;

namespace CHXDatabaseLibrary
{
    public abstract class CHXDatabaseConnection
    {
        string _version;
        CHXDatabaseParameters _connectionParameters;
        ICHXDatabase _manager;
        public bool IsSpatial { get;  }


        public abstract void LoadVersion();
        public abstract void Init();
        public abstract bool CheckSpatial();
        public abstract IEnumerable<T> RunQuery<T>(CHXQuery query);
        public abstract string ToSql(QueryContainer queryContainer, bool addParameter);
        public abstract object ToParameter(QueryContainer queryContainer);


        public CHXDatabaseManager DatabaseManager { get; set; }

        public CHXDatabaseParameters ConnectionParameters
        {
            get
            {
                return _connectionParameters;
            }

            set
            {
                _connectionParameters = value;
            }
        }

        

        public string Version
        {
            get
            {
                return _version;
            }

            set
            {
                _version = value;
            }
        }

        

        internal CHXDatabaseConnection(CHXDatabaseParameters connectionParameters, ICHXDatabase manager)
        {
            _manager = manager;
            _connectionParameters = connectionParameters;


            Init();
            LoadVersion();
        }


        

    }
}
