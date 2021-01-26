using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public class V : BaseWord
    {
        public V()
        {
            Thread.Sleep(1000);//表面这个对象构造比较费时
            Console.WriteLine("字符V被构造");
        }
        public override string Display()
        {
            return "V";
        }
    }
}
