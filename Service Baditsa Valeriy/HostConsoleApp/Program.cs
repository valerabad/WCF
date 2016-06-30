using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using Service;

namespace SelfHostConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SELF HOST";
            // creating object for hosting service and registration endPoint
            // object creates in time self hosting
            using (var host = new ServiceHost(typeof(Service.DataTransferService)))
            {
                host.Open();               
                Console.WriteLine("Self Host started");
                Console.ReadKey();
            }
        }
    }
}
