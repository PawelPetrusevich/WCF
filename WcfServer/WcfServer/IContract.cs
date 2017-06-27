using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WcfServer
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
