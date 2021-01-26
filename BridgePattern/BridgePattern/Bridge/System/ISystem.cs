using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Bridge
{
    public interface ISystem
    {
        string System();
        string Version();
    }
}
