using CHXApiController;
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
    public class CHXDataServiceApiManager: ICHXApiController
    {

        public CHXDataServiceApiManager()
        {
            
        }


        public override string Call(string controllerName, string modelName, Request request, ClaimsPrincipal principal)
        {
            var controller = CHXDataApiControllerFactory.GetApiController(controllerName, principal);
            control(controller);


            var model = ((ICHXDataApiController)controller).GetModel(modelName);
            control((CHXDataApi)model);

            var converter = new CHXConverterManager(CHXConverterType.CHXHttpRequest);
            var requestData = (converter.Convert(request) as CHXRequest);

            ((CHXDataApi)model).Call(requestData);


            return "";
            
        }



        protected bool control(CHXDataApi model)
        {
            if (model == null) throw new KeyNotFoundException();

            if (!model.IsPermission) throw new UnauthorizedAccessException($"{model.ModelName} modeline yetkiniz bulunmuyor");


            return true;
        }
    }
}
