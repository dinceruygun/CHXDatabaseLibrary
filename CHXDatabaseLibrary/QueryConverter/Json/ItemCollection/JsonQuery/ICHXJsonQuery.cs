using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection.JsonQuery
{
    public abstract class ICHXJsonQuery
    {
        public abstract void Convert(dynamic jsonElement, ref QueryTable query);
    }
}
