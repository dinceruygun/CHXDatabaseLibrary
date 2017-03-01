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
            throw new NotImplementedException();
        }

        public override string GetPermissionName()
        {
            return "datacontroller";
        }
    }
}
