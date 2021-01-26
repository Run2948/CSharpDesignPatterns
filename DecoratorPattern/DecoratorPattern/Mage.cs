using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Mage : BaseCharacter
    {
        public override void Show()
        {
            Console.WriteLine("我是wow裸装法师Oye，下面开始我打装备的过程。。。");
        }
    }

    /// <summary>
    /// 戴头盔的法师
    /// </summary>
    public class MageWithHelmet : BaseCharacter
    {
        public override void Show()
        {
            Console.WriteLine("我是wow裸装法师Oye，下面开始我打装备的过程。。。");
            Console.WriteLine("我获取到一个头盔。。海盗船长的帽子");
        }
    }

    /// <summary>
    /// 戴肩膀的法师
    /// </summary>
    public class MageWithShoulder : BaseCharacter
    {
        public override void Show()
        {
            Console.WriteLine("我是wow裸装法师Oye，下面开始我打装备的过程。。。");
            Console.WriteLine("我获取到一个肩甲。。随便一个布甲");
        }
    }
}
