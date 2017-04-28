using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;
using CHXDataServiceSettings;
using CHXGeoJson;

namespace CHXDataModel
{
    public static class CHXDataModelManager
    {
        private static CHXModelCollection _modelCollection;

        public static CHXModelCollection ModelCollection
        {
            get
            {
                return _modelCollection;
            }
        }



        static CHXDataModelManager()
        {
            _modelCollection = new CHXModelCollection();
        }


        public static dynamic Query(string query, string server, CHXQueryType queryType)
        {
            var resultColumns = new List<string>();
            var resultFind = new List<QueryFindList>();


            var mydb = CHXDatabaseModelFactory.GetDatabase(server);

            if (mydb == null) throw new NullReferenceException($"{server} isimli veri tabanı bulunamadı");


            var convertQuery = mydb.ConvertQuery<string>(query, CHXQueryType.Json);


            if (convertQuery.Query.Any(q => q.QueryType == "model"))
            {
                var model = convertQuery.Query.Find(q => q.QueryType == "model");

                var qModel = CHXDataModelManager.ModelCollection.Find(model.TableName);

                if (qModel == null) throw new Exception("Model bulunamadı");

                convertQuery = mydb.ConvertQuery<string>(qModel.QueryString, CHXQueryType.Json);

                foreach (var item in model.Field)
                    resultColumns.Add(item.Name);


                resultFind = model.QueryFind;
            }
            else if (convertQuery.Query.Any(q => q.QueryType == "table"))
            {
                if (convertQuery.AddGeometry) convertQuery.GeometryColumn = mydb.Database.Tables.Find(t => t.TableName == convertQuery.GeometryTable && t.SchemaName == convertQuery.GeometryTableSchema).GeometryColumn.Name;
            }





            var result = mydb.RunQuery<dynamic>(convertQuery);



            //model sorgusu içerisinde filtreleme işlemi varsa uygulanır
            if (resultColumns.Count > 0)
            {
                result = (result as CHXFeatures).
                         Select(r => new CHXFeature()
                         {
                             properties = (r.properties.Where(p => resultColumns.Contains(p.Key)).ToDictionary(i => i.Key, i => i.Value)),
                             geometry = r.geometry
                         }).ToList();
            }



            if (resultFind.Count > 0)
            {

            }
            ///////////////////////////////////////////////////////




            return result;
        }
    }
}
