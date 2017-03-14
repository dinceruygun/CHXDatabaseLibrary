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
        private static Dictionary<string, string> _settingsList;

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

        public static string Get(string name)
        {
            lock (_locker)
            {
                if (_settingsList.ContainsKey(name)) return _settingsList[name];




                var filters = new CHXFilters();
                filters.Add(new CHXFilter() { Field = "parameter", Operator = CHXQueryOperator.AND, Value = name });

                var olddata = IndexManager.Search(filters);

                if (olddata == null) return null;

                if (olddata.Rows[0]["parameter"]?.ToString() != name) return null;

                return olddata.Rows[0]["value"]?.ToString();
            }
        }



        public static void Set(string name, string value)
        {
            lock (_locker)
            {
                if (string.IsNullOrEmpty(name)) throw new NullReferenceException("parametre name değeri boş olamaz");
                if (string.IsNullOrEmpty(value)) throw new NullReferenceException("parametre value değeri boş olamaz");



                var indexdata = new Dictionary<string, string>();
                indexdata.Add("parameter", name);
                indexdata.Add("value", value);

                var filters = new CHXFilters();
                filters.Add(new CHXFilter() { Field = "parameter", Operator = CHXQueryOperator.AND, Value = name });

                var olddata = IndexManager.Search(filters);

                if (olddata != null)
                    IndexManager.Delete(filters);

                IndexManager.Index(indexdata);


                if (_settingsList.ContainsKey(name)) _settingsList[name] = value;
                else _settingsList.Add(name, value);
            }
        }

        static CHXSettingsManager()
        {
            _settingsList = new Dictionary<string, string>();
        }
    }
}
