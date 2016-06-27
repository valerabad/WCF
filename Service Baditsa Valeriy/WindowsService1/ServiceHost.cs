using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;

namespace WindowsService1
{
    public partial class ServiceHost : ServiceBase
    {
        private System.ServiceModel.ServiceHost host;
        public ServiceHost()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Console.Title = "Server";
            //Console.WriteLine("Server is runnig");
            //Console.ReadKey();
            host = new System.ServiceModel.ServiceHost(typeof(Service.DataTransferService));
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
                host.Close();
        }
    }
}
