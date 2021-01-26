using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class N : BaseWord
    {
        public N()
        {
            Thread.Sleep(1000);
            Console.WriteLine("字符N被构造");
        }
        public override string Display()
        {
            return "N";
        }
    }
}
