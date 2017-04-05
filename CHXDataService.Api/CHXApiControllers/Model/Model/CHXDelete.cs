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
    public class CHXDelete : CHXDataApi, ICHXDataApiModel
    {
        public CHXDelete(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            if (method.ToLower() != "post") return null;

            var _name = data.Find("name");


            if (_name == null) return null;


            CHXDataModelManager.ModelCollection.Remove(_name.Value.ToString());


            return "OK";
        }

        public override string GetPermissionName()
        {
            return "model.delete";
        }
    }
}
