using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;

namespace WCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(Service1)/*, new Uri[] { new Uri("http://localhost:1100") }*/);
            host.AddServiceEndpoint(typeof(IService1), new NetTcpBinding(), "net.tcp://localhost/wcftcp");

            host.Open();
            Console.ReadKey();
            host.Close();
        }
    }
}
