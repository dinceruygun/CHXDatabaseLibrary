using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Data.Model
{
    public class CHXGetAllTables : CHXDataApi, ICHXDataApiModel
    {
        public CHXGetAllTables(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            var serverName = data.Find("server");
            var schemaName = data.Find("schema");

            if (serverName == null) return null;


            var myDatabase = CHXDatabaseFactory.GetDatabase(serverName.Value.ToString());

            if (myDatabase == null) return null;

            var resultData = myDatabase.Database.Tables.Where(d => d.SchemaName == schemaName.Value.ToString()).Select(d =>
            new
            {
                name = d.TableName,
                isspatial = d.IsSpatial
            });

            return resultData;
        }

        public override string GetPermissionName()
        {
            return "data.getalltables";
        }
    }
}
