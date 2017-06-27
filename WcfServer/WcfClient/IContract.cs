using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfClient
{
    
        [ServiceContract]
        interface IContract
        {
            [OperationContract]
            string FullSpace(string diskName);
            [OperationContract]
            string FreeSpace(string diskName);
        }
    
}
