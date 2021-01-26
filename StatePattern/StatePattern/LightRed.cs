using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class LightRed : LightBase
    {
        /// <summary>
        /// 初始化的时候 指定灯的颜色
        /// </summary>
        public LightRed()
        {
            base.Color = LightColor.Red;
        }
        public override void Show()
        {
            Console.WriteLine("红灯停");
        }

        public override void Turn()
        {
            this.Color = LightColor.Blue;
        }

        public override void TurnContext(Context context)
        {
            context.CurrentLight = new LightBlue();
        }
    }
}
