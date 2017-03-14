using CHXIndex;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXSettings
{
    public static class CHXSettingsManager
    {
        private static CHXIndexManager _indexManager;
        private static object _locker = new object();

        public static CHXIndexManager IndexManager
        {
            get
            {
                if (_indexManager == null)
                {
                    lock (_locker)
                    {
                        if (_indexManager == null)
                        {
                            _indexManager = new CHXIndexManager("Settings");
                        }
                    }
                }

                return _indexManager;
            }
        }

        public static void Set(string name, string value)
        {
            IndexManager.Index(name, value);
        }

        static CHXSettingsManager()
        {
            
        }
    }
}
