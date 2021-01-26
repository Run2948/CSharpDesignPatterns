using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// 头盔装饰器
    /// </summary>
    public class DecoratorHelmet : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorHelmet(BaseCharacter character)
            : base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();

            Console.WriteLine("我获取到一个头盔。。海盗船长的帽子");
        }
    }
}
