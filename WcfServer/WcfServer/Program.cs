using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service));
            host.AddServiceEndpoint(
                typeof(IContract),
                new WSHttpBinding(),
                "http://localhost:80/Temporary_Listen_Addresses/");
            host.Open();
            Console.WriteLine("Service Run");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            host.Close();
        }
    }
}
