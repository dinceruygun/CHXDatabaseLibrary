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

        public override object Call(CHXRequest data, string method)
        {
            return null;
        }

        public ICHXDataApiModel GetModel(string modelName)
        {
            switch (modelName.ToLower())
            {
                case "getalltables":
                    return new Model.CHXGetAllTables(base.Principal);
                case "getallviews":
                    return new Model.CHXGetAllView(base.Principal);
                case "getallsequences":
                    return new Model.CHXGetAllSequences(base.Principal);
                case "getallindexes":
                    return new Model.CHXGetAllIndexes(base.Principal);
                case "getallconstraints":
                    return new Model.CHXGetAllConstraints(base.Principal);
                case "gettable":
                    return new Model.CHXGetTable(base.Principal);
                case "getview":
                    return new Model.CHXGetView(base.Principal);
                case "getconstraint":
                    return new Model.GetConstraint(base.Principal);
                case "getindex":
                    return new Model.CHXGetIndex(base.Principal);
                case "getsequence":
                    return new Model.CHXGetSequence(base.Principal);
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
