using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Service;

namespace HostConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "HOST";
            using (var host = new ServiceHost(typeof(Service.Service1)))
            {
                host.Open();
                Console.WriteLine("Host started");
                Console.ReadKey();
            }
        }
    }
}
