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
    public class CHXGetAllModel : CHXDataApi, ICHXDataApiModel
    {
        public CHXGetAllModel(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            if (method.ToLower() != "get") return null;

            return CHXDataModelManager.ModelCollection.ModelList.Select(m => m.Name);
        }

        public override string GetPermissionName()
        {
            return "model.getallmodel";
        }
    }
}
