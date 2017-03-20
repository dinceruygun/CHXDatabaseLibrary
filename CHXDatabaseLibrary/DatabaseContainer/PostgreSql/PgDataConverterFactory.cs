using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.DatabaseContainer.PostgreSql
{
    public static class PgDataConverterFactory
    {
        private static object _locker = new object();

        public static IPgDataConverter GetConverter(string typeName)
        {
            switch (typeName)
            {
                case "Object":
                    return new PgToFeatureCollection();
                default:
                    return null;
            }
        }
    }
}
