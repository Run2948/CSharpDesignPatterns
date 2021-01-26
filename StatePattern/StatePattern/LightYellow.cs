using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class LightYellow : LightBase
    {
        /// <summary>
        /// 初始化的时候 指定灯的颜色
        /// </summary>
        public LightYellow()
        {
            base.Color = LightColor.Yellow;
        }
        public override void Show()
        {
            Console.WriteLine("黄灯请小心");
        }

        public override void Turn()
        {
            this.Color = LightColor.Red;
        }

        public override void TurnContext(Context context)
        {
            context.CurrentLight = new LightRed();
        }
    }
}
