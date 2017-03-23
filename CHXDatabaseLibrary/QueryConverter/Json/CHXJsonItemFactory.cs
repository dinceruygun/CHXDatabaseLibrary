using CHXDatabaseLibrary.QueryConverter.Json.ItemCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter.Json
{
    public static class CHXJsonItemFactory
    {
        private static object _locker = new object();

        public static ICHXJsonItemConverter GetItemConverter(string itemName)
        {
            lock (_locker)
            {
                switch (itemName)
                {
                    case "server":
                        return new CHXJsonServer();
                    case "query":
                        return new CHXJsonQuery();
                    case "schema":
                        return new CHXJsonSchema();
                    case "join":
                        return new CHXJsonJoin();
                    case "group":
                        return new CHXJsonGroup();
                    default:
                        return null;
                }
            }
        }
    }
}
