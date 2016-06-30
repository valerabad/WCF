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
        private System.ServiceModel.ServiceHost host = null;
        public ServiceHost()
        {            
            InitializeComponent();
        }

        // creating and opening a new ServiceHost instance
        protected override void OnStart(string[] args)
        {
            if (host != null)
            {
                host.Close();
            }
            // Create a host for the DataTransferService type and provide the base address            
            host = new System.ServiceModel.ServiceHost(typeof(Service.DataTransferService));
            // Open the host to create listeners and start listening for messages           
            host.Open();
        }

        protected override void OnStop()
        {
            if (host != null)
            {
                host.Close();
                host = null;
            }
        }
    }
}
