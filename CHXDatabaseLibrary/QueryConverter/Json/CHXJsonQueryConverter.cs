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

            if (jsonObj.server == null) throw new Exception("Server adı bulunamadı");
            if (jsonObj.query == null) throw new Exception("Query bulunamadı");


            var queryContainer = new QueryContainer();
            queryContainer.Server = jsonObj.server;
            queryContainer.Schema = jsonObj.schema;


            queryContainer.Query = new QueryCollection();
            queryContainer.Join = new List<QueryJoin>();
            queryContainer.Group = new List<string>();

            int uniqueId = 0;

            foreach (var q in jsonObj.query)
            {
                var _query = new QueryTable();

                _query.TableName = q.Name;
                _query.QueryType = q.Value.type.Value;
                _query.AddGeometry = q.Value.addgeometry == null ? false : q.Value.addgeometry.Value;

                if (_query.AddGeometry)
                {
                    queryContainer.AddGeometry = true;
                    queryContainer.GeometryTable = _query.TableName;
                    queryContainer.GeometryTableSchema = queryContainer.Schema;
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

                queryContainer.Query.Add(_query);
            }




            //Tablolar arası ilişkiler dönüştürülüyor
            if (jsonObj.join != null)
            {
                foreach (var j in jsonObj.join)
                {
                    var _joinType = JoinType.INNER;

                    if (j.Name == "inner") _joinType = JoinType.INNER;
                    if (j.Name == "left") _joinType = JoinType.LEFT;
                    if (j.Name == "right") _joinType = JoinType.RIGHT;


                    if (j.Value != null)
                    {
                        foreach (var item in j.Value)
                        {
                            var join = new QueryJoin();
                            join.joinType = _joinType;
                            join.Destination = item.Name;
                            join.Target = item.Value;


                            queryContainer.Join.Add(join);
                        }
                    }
                }
            }





            //Gruplama yapılıyor
            if (jsonObj.group != null)
            {
                foreach (var g in jsonObj.group)
                {
                    queryContainer.Group.Add(g.Value);
                }
            }



            return queryContainer;
        }
    }
}
