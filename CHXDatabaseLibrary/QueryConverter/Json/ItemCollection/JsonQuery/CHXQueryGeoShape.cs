using CHXGeoJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection.JsonQuery
{
    public class CHXQueryGeoShape : ICHXJsonQuery
    {
        public override void Convert(dynamic jsonElement, ref QueryTable query)
        {
            if (jsonElement.Value == null) return;

            var geometry = new CHXGeometry();
            geometry.ReadGeoJson(jsonElement.Value.location.shape.ToString());

            var relation = (CHXGeometryRelation)System.Enum.Parse(typeof(CHXGeometryRelation), jsonElement.Value.location.relation.ToString());

            if (geometry == null) return;

            query.QueryGeometryList = new List<QueryGeometry>();

            query.QueryGeometryList.Add(new QueryGeometry()
            {
                Geometry = geometry,
                Relation = relation
            });
        }
    }
}
