using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection.JsonQuery
{
    public class CHXQueryFind : ICHXJsonQuery
    {
        public override void Convert(dynamic jsonElement, ref QueryTable query)
        {
            
            if (jsonElement.Value == null) return;

            int uniqueId = 0;


            foreach (var f in jsonElement.Value)
            {
                var findList = new QueryFindList();

                foreach (var item in f)
                {
                    findList.Add(new QueryFind(item.Name, item.Value.Value, uniqueId++));
                }

                query.QueryFind.Add(findList);
            }
        }
    }
}
