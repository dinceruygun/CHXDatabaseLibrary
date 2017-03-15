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
        public override object Convert<T>(T data)
        {
            dynamic jsonObj = JsonConvert.DeserializeObject(data.ToString());

            if (jsonObj.server == null) throw new Exception("Server adı bulunamadı");
            if (jsonObj.query == null) throw new Exception("Query bulunamadı");

            foreach (var q in jsonObj.query)
            {
                var tableName = q.Name;
                var queryType = q.Value.type.Value;
                var addGeometry = q.Value.addgeometry.Value;

                foreach (var f in q.Value.field)
                {

                }

            }

            return "";
        }
    }
}
