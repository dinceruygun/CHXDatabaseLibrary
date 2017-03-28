using CHXDatabaseLibrary.QueryConverter.Json.ItemCollection.JsonQuery;
using CHXGeoJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection
{
    public class CHXJsonQuery : ICHXJsonItemConverter
    {
        public override void Convert(dynamic jsonItem, ref QueryContainer query)
        {
            

            foreach (var q in jsonItem.Value)
            {
                var _query = new QueryTable();

                _query.TableName = q.Name;


                if (q.Value == null) return;

                foreach (var item in q.Value)
                {
                    ICHXJsonQuery elementConverter = CHXJsonQueryElementFactory.GetElement(item.Name);
                    if (elementConverter != null)
                    {
                        elementConverter.Convert(item, ref _query);
                    }
                }


                if (_query.AddGeometry)
                {
                    query.AddGeometry = true;
                    query.GeometryTable = _query.TableName;
                    query.GeometryTableSchema = query.Schema;
                }



                query.Query.Add(_query);
            }
        }
    }
}
