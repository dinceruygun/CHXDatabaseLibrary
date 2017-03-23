using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection.JsonQuery
{
    public static class CHXJsonQueryElementFactory
    {
        private static object _locker = new object();

        public static ICHXJsonQuery GetElement(string elementName)
        {
            lock (_locker)
            {
                switch (elementName)
                {
                    case "type":
                        return new CHXQueryType();
                    case "addgeometry":
                        return new CHXQueryAddGeometry();
                    case "field":
                        return new CHXQueryField();
                    case "find":
                        return new CHXQueryFind();
                    case "geo_shape":
                        return new CHXQueryGeoShape();
                    default:
                        return null;
                }
            }
        }
    }
}
