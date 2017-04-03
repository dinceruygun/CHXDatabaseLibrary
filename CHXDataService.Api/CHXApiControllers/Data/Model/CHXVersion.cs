using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CHXDataModel;

namespace CHXDataService.Api.CHXApiControllers.Data.Model
{
    public class CHXVersion : CHXDataApi, ICHXDataApiModel
    {
        public CHXVersion(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            var serverName = data.Find("server");

            var myDatabase = CHXDatabaseFactory.GetDatabase(serverName.Value.ToString());

            if (myDatabase == null) return null;

            return myDatabase.Database.Version;
        }

        public override string GetPermissionName()
        {
            return "basic";
        }
    }
}
