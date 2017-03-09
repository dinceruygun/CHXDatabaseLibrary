using CHXConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api.CHXApiControllers.Settings
{
    public class CHXSettingsController: CHXDataApi, ICHXDataApiController
    {
        public CHXSettingsController(ClaimsPrincipal principal) : base(principal)
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
                case "adddatabase":
                    return new Model.CHXAddDatabase(base.Principal);
                default:
                    return null;
            }
        }

        public override string GetPermissionName()
        {
            return "settings";
        }
    }
}
