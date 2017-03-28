using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection.JsonQuery
{
    public class CHXQueryAddGeometry : ICHXJsonQuery
    {
        public override void Convert(dynamic jsonElement, ref QueryTable query)
        {
            if (jsonElement.Value == null) return;

            query.AddGeometry = jsonElement.Value == null ? false : jsonElement.Value;
        }
    }
}
