using CHXDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXDatabaseLibrary.QueryConverter
{
    public static class CHXQueryConverterFactory
    {
        private static object _locker = new object();

        public static ICHXQueryConverter GetQueryConverter(CHXQueryType queryType)
        {
            switch (queryType)
            {
                case CHXQueryType.Json:
                    return new Json.CHXJsonQueryConverter();
                default:
                    return null;
            }
        }
    }
}
