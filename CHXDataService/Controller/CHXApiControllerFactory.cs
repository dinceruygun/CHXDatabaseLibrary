using CHXApiController;
using CHXDataService.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Controller
{
    public static class CHXApiControllerFactory
    {
        static List<ICHXApiController> _controllerList = new List<ICHXApiController>();
        static object _locker = new object();

        public static ICHXApiController GetController(string controllerName)
        {
            lock (_locker)
            {
                var controller = _controllerList.Find(c => c.ControlName == controllerName);

                if (controller == null)
                {
                    switch (controllerName)
                    {
                        case "data":
                            controller = new CHXDataServiceApiManager();
                            break;
                        case "settings":
                            controller = new CHXDataServiceApiManager();
                            break;
                        case "model":
                            controller = new CHXDataServiceApiManager();
                            break;
                        default:
                            break;
                    }

                    if (controller != null)
                    {
                        controller.ControlName = controllerName;
                        _controllerList.Add(controller);
                    }
                }

                return controller;
            }
        }
    }
}
