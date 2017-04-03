using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using CHXDataModel;

namespace CHXDataService.Api.CHXApiControllers.Settings.Model
{
    public class CHXGetAllDatabase : CHXDataApi, ICHXDataApiModel
    {
        public CHXGetAllDatabase(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            if (method.ToLower() != "get") return null;


            return CHXDatabaseFactory.DatabaseCollection.DatabaseList.Select(d =>
                        new CHXDatabaseSettings()
                        {
                            name = d.Name,
                            parameters = d.Database.Database.ConnectionParameters,
                            type = d.Database.Database.DatabaseType
                        });
        }

        public override string GetPermissionName()
        {
            return "settings.getalldatabase";
        }
    }
}
