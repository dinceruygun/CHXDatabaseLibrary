using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CHXDataModel;
using CHXDataServiceSettings;

namespace CHXDataService.Api.CHXApiControllers.Settings.Model
{
    public class CHXDeleteDatabase : CHXDataApi, ICHXDataApiModel
    {
        public CHXDeleteDatabase(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            if (method.ToLower() != "post") return null;

            var _name = data.Find("name");


            CHXDatabaseModelFactory.DeleteDatabase(_name.Value.ToString());

            return "OK";
        }

        public override string GetPermissionName()
        {
            return "settings.deletedatabase";
        }
    }
}
