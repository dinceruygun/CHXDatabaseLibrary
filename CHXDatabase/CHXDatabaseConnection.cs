using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO
{
    public abstract class CHXDatabaseConnection
    {
        string _version;
        CHXDatabaseParameters _connectionParameters;
        ICHXDatabase _manager;
        public bool IsSpatial { get; }


        public abstract void LoadVersion();
        public abstract void InitMethod();

        public abstract bool CheckSpatial();
        public abstract IEnumerable<T> RunQuery<T>(CHXQuery query);
        public abstract string ToSql(QueryContainer queryContainer, bool addParameter);
        public abstract object ToParameter(QueryContainer queryContainer);


        public ICHXDatabaseManager DatabaseManager { get; set; }

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



        public CHXDatabaseConnection(CHXDatabaseParameters connectionParameters, ICHXDatabase manager)
        {
            _manager = manager;
            _connectionParameters = connectionParameters;

            InitMethod();

            LoadVersion();
        }




    }
}
