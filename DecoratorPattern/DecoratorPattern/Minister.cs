using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 牧师
    /// </summary>
    public class Minister : BaseCharacter
    {
        public override void Show()
        {
            Console.WriteLine("我是wow裸装牧师卖血上的网，下面开始我打装备的过程。。。");
        }
    }
}
