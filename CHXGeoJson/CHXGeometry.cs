using GeoAPI.Geometries;
using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using NetTopologySuite.IO.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXGeoJson
{
    public class CHXGeometry
    {
        public string type { get; set; }
        public object coordinates { get; set; }



        public void ReadWkt(string wkt)
        {

            IGeometryFactory geometryFactory = new GeometryFactory();
            List<IGeometry> poly = new List<IGeometry>();
            WKTReader rdr = new WKTReader(geometryFactory);
            poly.Add(rdr.Read(wkt));

            if (poly.Count < 1) return;

            this.type = poly[0].GeometryType;


            switch (poly[0].OgcGeometryType)
            {
                case OgcGeometryType.Polygon:
                case OgcGeometryType.LineString:
                case OgcGeometryType.Point:
                    this.coordinates = ConvertCoordinates(poly[0].Coordinates);
                    break;
                case OgcGeometryType.MultiPolygon:
                    this.coordinates = new List<dynamic>();
                    foreach (var item in (poly[0] as MultiPolygon).Geometries)
                        (coordinates as List<dynamic>).Add(ConvertCoordinates(item.Coordinates));
                    break;
                case OgcGeometryType.MultiPoint:
                    this.coordinates = new List<dynamic>();
                    foreach (var item in (poly[0] as MultiPoint).Geometries)
                        (coordinates as List<dynamic>).Add(ConvertCoordinates(item.Coordinates));
                    break;
                case OgcGeometryType.MultiLineString:
                    this.coordinates = new List<dynamic>();
                    foreach (var item in (poly[0] as MultiLineString).Geometries)
                        (coordinates as List<dynamic>).Add(ConvertCoordinates(item.Coordinates));
                    break;
                default:
                    break;
            }

        }



        private object ConvertCoordinates(object value)
        {

            if (value == null)
            {
                return null;
            }

            List<List<Coordinate[]>> coordinatesss = value as List<List<Coordinate[]>>;
            if (coordinatesss != null)
            {
                var result = new List<List<List<List<double>>>>();

                foreach (var c in coordinatesss)
                {
                    var c1 = new List<List<List<double>>>();

                    foreach (var cc in c)
                    {
                        var c2 = new List<List<double>>();

                        foreach (var ccc in cc)
                        {
                            var c3 = new List<double>();
                            c3.Add(ccc.X);
                            c3.Add(ccc.Y);

                            c2.Add(c3);
                        }

                        c1.Add(c2);
                    }

                    result.Add(c1);
                }

                return null;
            }




            List<Coordinate[]> coordinatess = value as List<Coordinate[]>;
            if (coordinatess != null)
            {
                var result = new List<List<List<double>>>();
                foreach (var c in coordinatess)
                {
                    var cc = new List<List<double>>();

                    foreach (var item in c)
                    {
                        var ccc = new List<double>();
                        ccc.Add(item.X);
                        ccc.Add(item.Y);

                        cc.Add(ccc);
                    }
                    

                    result.Add(cc);
                }

                return result;
            }




            IEnumerable<Coordinate> coordinates = value as IEnumerable<Coordinate>;
            if (coordinates != null)
            {
                var result = new List<List<double>>();
                foreach (var c in coordinates)
                {
                    var cc = new List<double>();
                    cc.Add(c.X);
                    cc.Add(c.Y);

                    result.Add(cc);
                }

                return result;
            }

            Coordinate coordinate = value as Coordinate;
            if (coordinate != null)
            {
                var result = new List<double>();
                result.Add(coordinate.X);
                result.Add(coordinate.Y);

                return result;
            }


            return null;
        }

    }

}
