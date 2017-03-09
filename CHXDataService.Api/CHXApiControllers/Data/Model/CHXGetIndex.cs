using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Data.Model
{
    public class CHXGetIndex : CHXDataApi, ICHXDataApiModel
    {
        public CHXGetIndex(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            var serverName = data.Find("server");
            var schemaName = data.Find("schema");
            var indexname = data.Find("indexname");

            if (serverName == null) return null;


            var myDatabase = CHXDatabaseFactory.GetDatabase(serverName.Value.ToString());

            if (myDatabase == null) return null;

            var resultData = myDatabase.Database.Indexes.Where(d => d.SchemaName == schemaName.Value.ToString() && d.IndexName == indexname.Value.ToString()).Select(d =>
            new {
                name = d.IndexName,
                columnname = d.ColumnName,
                isunique = d.IsUnique,
                tablename = d.TableName,
                schemaname = d.SchemaName
            });

            return resultData;
        }

        public override string GetPermissionName()
        {
            return "data.getindex";
        }
    }
}
