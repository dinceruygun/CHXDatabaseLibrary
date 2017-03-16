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


            var queryContainer = new QueryContainer();
            queryContainer.Server = jsonObj.server;
            queryContainer.Schema = jsonObj.schema;


            queryContainer.Query = new QueryCollection();

            foreach (var q in jsonObj.query)
            {
                var _query = new QueryTable();

                _query.TableName = q.Name;
                _query.QueryType = q.Value.type.Value;
                _query.AddGeometry = q.Value.addgeometry == null ? false : q.Value.addgeometry.Value;

                foreach (var f in q.Value.field)
                {
                    string _tempVal = f.Value;

                    if (_tempVal.IndexOf("=>") > -1) _query.Field.Add(new QueryField((_tempVal.Substring(0, _tempVal.IndexOf("=>") - 1).Trim()), _tempVal.Substring(_tempVal.IndexOf("=>") + 2, _tempVal.Length - _tempVal.IndexOf("=>") - 2).Trim()));
                    else
                        _query.Field.Add(new QueryField(_tempVal));

                }

                if (q.Value.find != null)
                {
                    foreach (var f in q.Value.find)
                    {
                        var findList = new QueryFindList();

                        foreach (var item in f)
                        {
                            findList.Add(new QueryFind(item.Name, item.Value.Value));
                        }

                        _query.QueryFind.Add(findList);
                    }
                }


                queryContainer.Query.Add(_query);
            }



            

            return queryContainer;
        }
    }
}
