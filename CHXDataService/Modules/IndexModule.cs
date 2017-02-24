using System.Text.RegularExpressions;
using Nancy;
using System.Collections.Generic;

namespace CHXDataService.Modules
{
    public class IndexModule: NancyModule
    {
        public IndexModule()
        {

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
            Get["/Log"] = parameters =>
            {
                return View["index"];
            };


            Get["/check"] = x =>
            {
                if (checkAllowAddress(Request.UserHostAddress))
                {
                    //NetgisCheckContainer.CheckNetgis(Request.UserHostAddress);
                    return "OK";
                }
                else
                {
                    return "Yetkiniz bulunmuyor!";
                }

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
