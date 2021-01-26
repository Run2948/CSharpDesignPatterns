using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge
{
    public class IOSSystem : ISystem
    {

        public string System()
        {
            return "IOS";
        }
        public string Version()
        {
            return "9.4";
        }

    }
}
