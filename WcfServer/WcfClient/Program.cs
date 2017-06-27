using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IContract> temp = new ChannelFactory<IContract>(
                new WSHttpBinding(),
                new EndpointAddress("http://localhost:80/Temporary_Listen_Addresses/"));
            IContract chanell = temp.CreateChannel();
            Console.WriteLine("Enter DiskName:");
            string diskname=Console.ReadLine();
            Console.WriteLine("FullSize:"+chanell.FullSpace(diskname));
            Console.WriteLine("FreeSpace"+chanell.FreeSpace(diskname));
            Console.ReadKey();
        }
    }
}
