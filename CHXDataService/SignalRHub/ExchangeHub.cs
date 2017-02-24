using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Infrastructure;


namespace CHXDataService.SignalRHub
{
    public class ExchangeHub: Hub
    {
        public void Init(string urlHere)
        {
            Console.WriteLine(urlHere);
        }

        public void SendDataToClients(string data)
        {
            Clients.All.UpdateContent(data);
        }


        internal static void SendMessage(string message)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ExchangeHub>();
            hubContext.Clients.All.UpdateContent(message);
        }
    }
}
