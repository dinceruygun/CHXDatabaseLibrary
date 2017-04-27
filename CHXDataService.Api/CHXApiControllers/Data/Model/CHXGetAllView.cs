using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CHXDataModel;
using CHXDataServiceSettings;

namespace CHXDataService.Api.CHXApiControllers.Data.Model
{
    public class CHXGetAllView : CHXDataApi, ICHXDataApiModel
    {
        public CHXGetAllView(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            var serverName = data.Find("server");
            var schemaName = data.Find("schema");

            if (serverName == null) return null;


            var myDatabase = CHXDatabaseModelFactory.GetDatabase(serverName.Value.ToString());

            if (myDatabase == null) return null;

            var resultData = myDatabase.Database.Views.Where(d => d.SchemaName == schemaName.Value.ToString()).Select(d => new { name = d.TableName });

            return resultData;
        }

        public override string GetPermissionName()
        {
            return "data.getallviews";
        }
    }
}
