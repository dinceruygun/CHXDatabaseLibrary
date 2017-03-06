using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Data.Model
{
    public class CHXGetAllSequences: CHXDataApi, ICHXDataApiModel
    {
        public CHXGetAllSequences(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data)
        {
            var serverName = data.Find("server");
            var schemaName = data.Find("schema");

            if (serverName == null) return null;


            var myDatabase = CHXDatabaseFactory.GetDatabase(serverName.Value.ToString());

            if (myDatabase == null) return null;

            var resultData = myDatabase.Database.Sequences.Where(d => d.SchemaName == schemaName.Value.ToString()).Select(d => 
            new {
                name = d.SequenceName,
                maximumvalue = d.MaximumValue,
                minimumvalue = d.MinimumValue,
                startvalue = d.StartValue,
                tablename = d.TableName,
                currentvalue = d.CurrentValue,
                schemaname = d.SchemaName
            });

            return resultData;
        }

        public override string GetPermissionName()
        {
            return "data.getallsequences";
        }
    }
}
