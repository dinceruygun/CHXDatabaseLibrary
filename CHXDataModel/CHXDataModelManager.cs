using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;

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
            var mydb = CHXDatabaseFactory.GetDatabase(server);

            if (mydb == null) throw new NullReferenceException($"{server} isimli veri tabanı bulunamadı");


            var convertQuery = mydb.Database.ConvertQuery<string>(query, CHXQueryType.Json);
            var result = mydb.Database.RunQuery<dynamic>(convertQuery);


            return result;
        }
    }
}
