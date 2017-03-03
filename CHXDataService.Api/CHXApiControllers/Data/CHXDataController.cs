using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Data
{
    public class CHXDataController : CHXApi, ICHXApiController
    {
        public CHXDataController(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override void Call(object data)
        {
            
        }

        public ICHXApiModel GetModel(string modelName)
        {
            switch (modelName.ToLower())
            {
                case "getalltables":
                    return new Model.CHXGetAllTables(base.Principal);
                default:
                    return null;
            }
        }

        public override string GetPermissionName()
        {
            return "data";
        }
    }
}
