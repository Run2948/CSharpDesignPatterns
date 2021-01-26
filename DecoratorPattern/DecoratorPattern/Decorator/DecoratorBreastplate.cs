using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// 胸甲装饰器
    /// </summary>
    public class DecoratorBreastplate : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorBreastplate(BaseCharacter character)
            : base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();

            Console.WriteLine("我获取到一个胸甲。。博学者法袍");
        }
    }
}
