using CHXConverter;
using CHXGeoJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CHXDatabase.IO;
using Newtonsoft.Json;
using CHXDataModel;

namespace CHXDataService.Api.CHXApiControllers.Model.Model
{
    public class CHXAdd : CHXDataApi, ICHXDataApiModel
    {
        public CHXAdd(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            if (method.ToLower() != "post") return null;


            var _name = data.Find("name");
            var _model = data.Find("model");


            var _server = data.Find("server");
            var _schema = data.Find("schema");
            var _query = data.Find("query");

            if (_server == null) return null;
            if (_query == null) return null;


            var result = CHXDataModelManager.Query((data.ConvertData.model.ToString() as string), _server.Value.ToString(), CHXQueryType.Json);

            if (result is CHXFeatures)
            {
                var model = new CHXModel() { Name = _name.Value.ToString(), QueryString = data.ConvertData.model.ToString() };


                CHXDataModelManager.ModelCollection.Add(model);
            }
            else
            {
                throw new Exception("Query doğru çalışmadı");
            }



            var collection = new CHXFeatureCollection();
            collection.features = result as CHXFeatures;
            collection.type = "FeatureCollection";

            return "OK";
        }

        public override string GetPermissionName()
        {
            return "model.add";
        }
    }
}
