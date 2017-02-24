using Microsoft.Owin.Hosting;
using Nancy;
using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CHXDataService
{
    static class tempAllowAddress
    {
        public static string Address { get; set; }
    }

    public class HostService
    {
        NancyHost _host;
        private IDisposable _server = null;
        string _port;
        string _allowAddress;


        public HostService(string port, string allowAddress)
        {
            _port = port;
            _allowAddress = allowAddress;

            tempAllowAddress.Address = _allowAddress;

            Initialize();
        }

        public NancyHost Host
        {
            get
            {
                return _host;
            }
        }

        public string Port
        {
            get
            {
                return _port;
            }
        }

        public string AllowAddress
        {
            get
            {
                return _allowAddress;
            }
        }

        private void Initialize()
        {
            string url = $"http://*:{_port}";
            _server = WebApp.Start<Startup>(url: url);
            //_host = new NancyHost(new Uri(url));

        }

        internal void Start()
        {
            //_host.Start();
        }

        internal void Stop()
        {
            if (_server != null)
            {
                _server.Dispose();
            }

            // _host.Stop();
        }
    }
}
