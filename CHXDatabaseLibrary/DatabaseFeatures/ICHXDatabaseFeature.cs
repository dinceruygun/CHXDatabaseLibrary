using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.DatabaseFeatures
{
    public abstract class ICHXDatabaseFeature
    {
        CHXDatabaseManager _databaseManager;
        public string exdata1 { get; set; }
        public string exdata2 { get; set; }
        public string exdata3 { get; set; }


        public CHXDatabaseManager DatabaseManager
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

        public void SetDatabaseManager(CHXDatabaseManager manager)
        {
            _databaseManager = manager;
        }

    }
}
