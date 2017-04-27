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
    public class CHXStatus : CHXDataApi, ICHXDataApiModel
    {
        public CHXStatus(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            var serverName = data.Find("server");

            var myDatabase = CHXDatabaseModelFactory.GetDatabase(serverName.Value.ToString());

            if (myDatabase == null) return null;

            return myDatabase.Database.Status;
        }

        public override string GetPermissionName()
        {
            return "basic";
        }
    }
}
