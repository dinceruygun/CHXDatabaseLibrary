using CHXDatabase;
using CHXGeoJson;
using GeoAPI.Geometries;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

namespace CHXPostgreSqlLibrary
{
    public class PgToFeatureCollection : IPgDataConverter
    {
        public override IEnumerable<T> Convert<T>(CHXQuery query, dynamic data)
        {

            var collection = new CHXFeatureCollection();


            foreach (var row in data)
            {
                var feature = new CHXFeature();

                feature.properties = new Dictionary<string, object>();

                foreach (var col in (row as IDictionary<string, object>))
                {

                    if (col.Key == query.GeometryColumn)
                    {
                        if (query.AddGeometry)
                        {
                            var geom = new CHXGeometry();
                            geom.ReadWkt(col.Value.ToString());

                            feature.geometry = geom;
                        }
                    }
                    else
                    {
                        feature.properties.Add(col);
                    }
                }


                collection.features.Add(feature);
            }


            return (collection.features as IEnumerable<T>);
        }
    }
}
