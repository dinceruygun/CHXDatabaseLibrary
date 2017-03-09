using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CHXApiController
{
    public abstract class ICHXApiController
    {
        public abstract string Call(string controllerName, string modelName, Request request, ClaimsPrincipal principal, string method);

        public string ControlName { get; set; }
    }
}
