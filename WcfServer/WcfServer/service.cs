using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WcfServer
{

    class Service : IContract
    {
        
        public string FreeSpace(string diskName)
        {
            DriveInfo di = new DriveInfo(diskName[0] + @":\");

            if (di.IsReady)
            {
                return (di.AvailableFreeSpace).ToString(); 
            }
            else
            {
                return "Disk not found";
            }
        }

        public string FullSpace(string diskName)
        {
            DriveInfo di = new DriveInfo(diskName[0] + @":\\");
            if (di.IsReady)
            {
             var space = di.TotalSize;
             return space.ToString();
            }
            else
            {
                return "Disk not found";
            }
           
        }
    }
}
