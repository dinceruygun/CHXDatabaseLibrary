using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;
using CHXDataServiceSettings;

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
            var mydb = CHXDatabaseModelFactory.GetDatabase(server);

            if (mydb == null) throw new NullReferenceException($"{server} isimli veri tabanı bulunamadı");


            var convertQuery = mydb.ConvertQuery<string>(query, CHXQueryType.Json);
            var result = mydb.RunQuery<dynamic>(convertQuery);


            return result;
        }
    }
}
