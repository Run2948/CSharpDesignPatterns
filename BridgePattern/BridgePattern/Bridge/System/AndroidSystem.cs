using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge
{
    public class AndroidSystem : ISystem
    {

        public string System()
        {
            return "Android";
        }
        public string Version()
        {
            return "6.0";
        }

    }
}
