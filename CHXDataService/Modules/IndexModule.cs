using System.Text.RegularExpressions;
using Nancy;
using System.Collections.Generic;
using CHXDataService.Api;
using System.Linq;
using System;


namespace CHXDataService.Modules
{
    public class IndexModule: SecureModule
    {

        CHXDataServiceApiManager apiManager;


        public IndexModule()
        {

            apiManager = new CHXDataServiceApiManager();


            Get[@"/{uri*}"] = parameters =>
            {
                var regex = new Regex(@"\.(png|gif|jpg|jpeg)$");
                if (regex.IsMatch(parameters.uri))
                {
                    return View["index"];
                }
                else
                {
                    return null;
                }
            };



            Get["/"] = _ =>
            {
                if (!IsAuthenticated)
                {
                    return HttpStatusCode.Forbidden;
                }

                return "Hello User!";
            };



            Post["/{controller}/{model}"] = parameters =>
            {

                if (!IsAuthenticated)
                {
                    return HttpStatusCode.Forbidden;
                }
                

                var controller = parameters.controller;
                var model = parameters.model;


                apiManager.Call(controller, model, this.Request, Principal);


                return HttpStatusCode.Forbidden;

            };


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
