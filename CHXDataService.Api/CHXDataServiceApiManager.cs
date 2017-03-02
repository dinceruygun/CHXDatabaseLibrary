using CHXConverter;
using CHXDataService.Api.CHXHttpRequest;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService.Api
{
    public class CHXDataServiceApiManager
    {
        public void Call(string controllerName, string modelName, Request request, ClaimsPrincipal principal)
        {
            var controller = CHXApiControllerFactory.GetApiController(controllerName, principal);
            control(controller);


            var model = ((ICHXApiController)controller).GetModel(modelName);
            control((CHXApi)model);



            var converter = new CHXConverterManager(CHXConverterType.CHXHttp);
            converter.Convert(request);




            var contentType = request.Headers.ContentType.GetContentType();


            ((CHXApi)model).Call("");
            
        }



        protected bool control(CHXApi model)
        {
            if (model == null) throw new KeyNotFoundException();

            if (!model.IsPermission) throw new UnauthorizedAccessException($"{model.ModelName} modeline yetkiniz bulunmuyor");


            return true;
        }
    }
}
