using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 交通灯
    /// </summary>
    public class TrafficLight
    {
        /// <summary>
        /// 0 绿灯  1 黄灯  2红灯
        /// </summary>
        public LightColor Color { get; set; }

        public void Show()
        {
            //switch (this.Color)
            //{
            //    case LightColor.Green:
            //        break;
            //    case LightColor.Yellow:
            //        break;
            //    case LightColor.Red:
            //        break;
            //    default:
            //        break;
            //}

            if (this.Color == LightColor.Green)
            {
                Console.WriteLine("绿灯行");
            }
            else if (this.Color == LightColor.Yellow)
            {
                Console.WriteLine("黄灯请小心");
            }
            else if (this.Color == LightColor.Red)
            {
                Console.WriteLine("红灯停");
            }
            else if (this.Color == LightColor.Blue)
            {
                Console.WriteLine("蓝灯减速");
            }
        }

        public void Turn()
        {
            if (this.Color == LightColor.Green)
            {
                this.Color = LightColor.Yellow;
            }
            else if (this.Color == LightColor.Yellow)
            {
                this.Color = LightColor.Red;
            }

            else if (this.Color == LightColor.Red)
            {
                this.Color = LightColor.Blue;
            }
            else if (this.Color == LightColor.Blue)
            {
                this.Color = LightColor.Green;
            }
        }

    }

    public enum LightColor
    {
        Green = 0,
        Yellow = 1,
        Red = 2,
        Blue = 3
    }
}
