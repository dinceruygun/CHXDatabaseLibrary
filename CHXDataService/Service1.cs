using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace CHXDataService
{
    public partial class Service1 : ServiceBase
    {
        HostService myHostService = null;


        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            myHostService = new HostService("1453", "192.168.2.126");

            myHostService.Start();


            //string url = "http://localhost:8080";

            //using (WebApp.Start<Startup>(url))
            //{
            //    Console.WriteLine("Server running on {0}", url);
            //    Console.ReadLine();
            //}


        }

        protected override void OnStop()
        {
            //myHostService.Stop();
        }
    }
}
