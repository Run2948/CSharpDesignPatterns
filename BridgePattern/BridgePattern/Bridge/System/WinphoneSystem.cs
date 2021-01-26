using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge
{
    public class WinphoneSystem : ISystem
    {

        public string System()
        {
            return "Winphone";
        }
        public string Version()
        {
            return "10.0";
        }

    }
}
