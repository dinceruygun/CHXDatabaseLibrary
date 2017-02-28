using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api
{
    public class CHXDataServiceApiManager
    {
        public void Call(string controllerName, string modelName, string data, IIdentity currentIdentity)
        {
            var controller = CHXApiControllerFactory.GetApiController(controllerName);

            if (controller == null) throw new KeyNotFoundException();

            var model = controller.GetModel(modelName);

        }
    }
}
