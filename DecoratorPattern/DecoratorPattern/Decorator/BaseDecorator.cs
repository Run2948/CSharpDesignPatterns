using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseDecorator : BaseCharacter
    {
        private BaseCharacter _BaseCharacter = null;
        public BaseDecorator(BaseCharacter character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();
        }
    }
}
