using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class LightBlue : LightBase
    {
        /// <summary>
        /// 初始化的时候 指定灯的颜色
        /// </summary>
        public LightBlue()
        {
            base.Color = LightColor.Blue;
        }
        public override void Show()
        {
            Console.WriteLine("蓝灯减速");
        }

        public override void Turn()
        {
            this.Color = LightColor.Green;
        }

        public override void TurnContext(Context context)
        {
            context.CurrentLight = new LightGreen();
        }
    }
}
