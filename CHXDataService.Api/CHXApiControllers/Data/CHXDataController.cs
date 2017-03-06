using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Data
{
    public class CHXDataController : CHXDataApi, ICHXDataApiController
    {
        public CHXDataController(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data)
        {
            return null;
        }

        public ICHXDataApiModel GetModel(string modelName)
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
