using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection
{
    public class CHXJsonSchema : ICHXJsonItemConverter
    {
        public override void Convert(dynamic jsonItem, ref QueryContainer query)
        {
            query.Schema = jsonItem.Value;
        }
    }
}
