using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api
{
    public static class CHXApiControllerFactory
    {
        private static object _locker = new object();

        public static ICHXApiController GetApiController(string controllerName)
        {
            if (controllerName == "data")
            {
                return new CHXApiControllers.Data.CHXDataController();
            }
            else { return null; }
        }
    }
}
