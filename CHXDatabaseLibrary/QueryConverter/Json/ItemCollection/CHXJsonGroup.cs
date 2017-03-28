using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection
{
    public class CHXJsonGroup : ICHXJsonItemConverter
    {
        public override void Convert(dynamic jsonItem, ref QueryContainer query)
        {
            //Gruplama yapılıyor
            if (jsonItem != null)
            {
                foreach (var g in jsonItem.Value)
                {
                    query.Group.Add(g.Value);
                }
            }
        }
    }
}
