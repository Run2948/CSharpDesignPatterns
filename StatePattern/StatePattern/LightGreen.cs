using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class LightGreen : LightBase
    {
        /// <summary>
        /// 初始化的时候 指定灯的颜色
        /// </summary>
        public LightGreen()
        {
            base.Color = LightColor.Green;
        }


        public override void Show()
        {
            Console.WriteLine("绿灯行");
        }

        public override void Turn()
        {
            this.Color = LightColor.Yellow;
        }

        public override void TurnContext(Context context)
        {
            context.CurrentLight = new LightYellow();
        }
    }
}
