using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// 腿甲装饰器
    /// </summary>
    public class DecoratorCuish : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorCuish(BaseCharacter character)
            : base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();

            Console.WriteLine("我获取到一个腿甲。。凌风腿甲");
        }
    }
}
