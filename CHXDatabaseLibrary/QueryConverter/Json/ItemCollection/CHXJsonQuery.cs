using CHXGeoJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDatabaseLibrary.QueryConverter.Json.ItemCollection
{
    public class CHXJsonQuery : ICHXJsonItemConverter
    {
        public override void Convert(dynamic jsonItem, ref QueryContainer query)
        {
            int uniqueId = 0;

            foreach (var q in jsonItem.Value)
            {
                var _query = new QueryTable();

                _query.TableName = q.Name;
                _query.QueryType = q.Value.type.Value;
                _query.AddGeometry = q.Value.addgeometry == null ? false : q.Value.addgeometry.Value;

                if (_query.AddGeometry)
                {
                    query.AddGeometry = true;
                    query.GeometryTable = _query.TableName;
                    query.GeometryTableSchema = query.Schema;
                }

                //Sorgu sonucu listelenecek alanlar
                //Hiç alan tanımlanmamış ise sorgu sonucunda tüm alanlar listelenir.
                if (q.Value.field != null)
                {
                    foreach (var f in q.Value.field)
                    {
                        string _tempVal = f.Value;

                        if (_tempVal.IndexOf("=>") > -1) _query.Field.Add(new QueryField((_tempVal.Substring(0, _tempVal.IndexOf("=>") - 1).Trim()), _tempVal.Substring(_tempVal.IndexOf("=>") + 2, _tempVal.Length - _tempVal.IndexOf("=>") - 2).Trim()));
                        else
                            _query.Field.Add(new QueryField(_tempVal));

                    }
                }



                //sorgulama kriterleri dönüştürülüypr
                if (q.Value.find != null)
                {
                    foreach (var f in q.Value.find)
                    {
                        var findList = new QueryFindList();

                        foreach (var item in f)
                        {
                            findList.Add(new QueryFind(item.Name, item.Value.Value, uniqueId++));
                        }

                        _query.QueryFind.Add(findList);
                    }
                }



                if (q.Value.geo_shape != null)
                {
                    var geometry = new CHXGeometry();
                    geometry.ReadGeoJson(q.Value.geo_shape.location.shape.ToString());

                    var relation = (CHXGeometryRelation)System.Enum.Parse(typeof(CHXGeometryRelation), q.Value.geo_shape.location.relation.ToString());


                }



                query.Query.Add(_query);
            }
        }
    }
}
