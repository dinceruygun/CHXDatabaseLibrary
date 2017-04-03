using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Model
{
    public class CHXQueryController : CHXDataApi, ICHXDataApiController
    {
        public CHXQueryController(ClaimsPrincipal principal) : base(principal)
        {

        }

        public override object Call(CHXRequest data, string method)
        {
            return null;
        }

        public ICHXDataApiModel GetModel(string modelName)
        {
            switch (modelName.ToLower())
            {
                case "query":
                    return new Model.CHXQuery(base.Principal);
                case "add":
                    return new Model.CHXAdd(base.Principal);
                default:
                    return null;
            }
        }

        public override string GetPermissionName()
        {
            return "model";
        }
    }
}
