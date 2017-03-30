using System.Text.RegularExpressions;
using Nancy;
using System.Collections.Generic;
using CHXDataService.Api;
using System.Linq;
using System;
using CHXDataService.Controller;
using CHXApiController;
using System.Diagnostics;
using System.Text;

namespace CHXDataService.Modules
{
    public class IndexModule: SecureModule
    {


        public IndexModule()
        {



            Get["/Home"] = _ =>
            {

                return View["index"];

            };


            Put["/{controller}/{model}"] = parameters =>
            {
                return CallMethod(parameters, "put");
            };



            Get["/{controller}/{model}"] = parameters =>
            {
                return CallMethod(parameters, "get");
            };

            

            Post["/{controller}/{model}"] = parameters =>
            {
                return CallMethod(parameters, "post");

            };


            

        }




        private object CallMethod(dynamic parameters, string method)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();



            if (!IsAuthenticated)
            {
                return HttpStatusCode.Forbidden;
            }

            var resultData = "";

            var controllerName = parameters.controller;
            var modelName = parameters.model;

            ICHXApiController controller = CHXApiControllerFactory.GetController(controllerName);

            if (controller != null)
            {
                resultData = controller.Call(controllerName, modelName, this.Request, Principal, method);
            }


            if (resultData != null)
            {
                return GetResponseData(resultData, ref stopwatch);
            }


            stopwatch.Stop();

            return HttpStatusCode.Found;
        }




        protected string GetResponseData(string data, ref Stopwatch stopwatch)
        {
            StringBuilder responseData = new StringBuilder();

            responseData.Append("{");
            responseData.Append("\"elapsed\":");
            responseData.Append("\"");
            responseData.Append(stopwatch.Elapsed);
            responseData.Append("\",");

            responseData.Append("\"data\":");
            responseData.Append(data);

            responseData.Append("}");

            return responseData.ToString();
        }


        private bool checkAllowAddress(string address)
        {
            var addressList = parseAddress(tempAllowAddress.Address);

            if (addressList.Count == 0) return true;
            else
            {
                if (addressList.Find(a => a.address == address) == null) return false;
                else return true;
            }

        }

        private List<HostAddress> parseAddress(string address)
        {
            var result = new List<HostAddress>();


            if (address == "*") return result;
            else
            {
                foreach (var item in address.Split(','))
                {
                    result.Add(new HostAddress() { address = item });
                }
            }


            return result;
        }
    }

    public class HostAddress
    {
        public string address { get; set; }
    }
}
