using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Data.Model
{
    public class CHXGetAllTables : CHXApi, ICHXApiModel
    {
        public CHXGetAllTables(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override void Call(object data)
        {
            
        }

        public override string GetPermissionName()
        {
            return "data.getalltables";
        }
    }
}
