using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class L : BaseWord
    {
        public L()
        {
            Thread.Sleep(1000);
            Console.WriteLine("字符L被构造");
        }
        public override string Display()
        {
            return "L";
        }
    }
}
