using CHXGeoJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter.Json
{
    public class CHXJsonQueryConverter : ICHXQueryConverter
    {
        public override QueryContainer Convert<T>(T data)
        {


            dynamic jsonObj = JsonConvert.DeserializeObject(data.ToString());


            var queryContainer = new QueryContainer();

            queryContainer.Query = new QueryCollection();
            queryContainer.Join = new List<QueryJoin>();
            queryContainer.Group = new List<string>();


            foreach (var item in jsonObj)
            {
                ICHXJsonItemConverter itemConverter = CHXJsonItemFactory.GetItemConverter(item.Name);
                if (itemConverter != null)
                {
                    itemConverter.Convert(item, ref queryContainer);
                }
            }


            return queryContainer;
        }
    }
}
