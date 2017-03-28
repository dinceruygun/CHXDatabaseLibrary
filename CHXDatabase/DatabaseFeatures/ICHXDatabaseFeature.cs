using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabase.IO.DatabaseFeatures
{
    public abstract class ICHXDatabaseFeature
    {
        ICHXDatabaseManager _databaseManager;
        public string exdata1 { get; set; }
        public string exdata2 { get; set; }
        public string exdata3 { get; set; }


        public ICHXDatabaseManager DatabaseManager
        {
            get
            {
                return _databaseManager;
            }

            set
            {
                _databaseManager = value;
            }
        }

        public void SetDatabaseManager(ICHXDatabaseManager manager)
        {
            _databaseManager = manager;
        }

    }
}
