using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Settings.Model
{
    public class CHXDeleteDatabase : CHXDataApi, ICHXDataApiModel
    {
        public CHXDeleteDatabase(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            if (method.ToLower() != "put") return null;

            var _name = data.Find("name");


             CHXDatabaseFactory.DeleteDatabase(_name.Value.ToString());

            return "OK";
        }

        public override string GetPermissionName()
        {
            return "settings.deletedatabase";
        }
    }
}
