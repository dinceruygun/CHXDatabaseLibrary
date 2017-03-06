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

        public override object Call(CHXRequest data)
        {
            return null;
        }

        public override string GetPermissionName()
        {
            return "data.getalltables";
        }
    }
}
