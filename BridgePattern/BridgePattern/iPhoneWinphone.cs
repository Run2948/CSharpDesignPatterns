using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 使用Android系统的iphone手机
    /// </summary>
    public class iPhoneWinphone : BasePhone
    {
        public override string System()
        {
            return "Winphone";
        }
        public override string Version()
        {
            return "10.0";
        }

        public override void Call()
        {
            Console.WriteLine("Use OS {0}.{1}.{2} Call", this.GetType().Name, this.System(), this.Version());
        }

        public override void Text()
        {
            Console.WriteLine("Use OS {0}.{1}.{2} Text", this.GetType().Name, this.System(), this.Version());
        }


    }
}
