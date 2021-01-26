using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 1 状态模式(State)介绍和使用
    /// 2 状态模式好处和实际的应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的的状态模式");
                {
                    TrafficLight light = new TrafficLight()
                    {
                        Color = LightColor.Green
                    };
                    light.Show();
                    light.Turn();
                    light.Show();
                    light.Turn();
                    light.Show();
                    light.Turn();
                }
                Console.WriteLine("******************************");
                {
                    LightBase light = new LightGreen();
                    light.Show();
                    light.Turn();
                    light.Show();
                    light.Turn();

                }
                Console.WriteLine("******************************");
                {
                    LightBase light = new LightGreen();
                    Context context = new Context()
                    {
                        CurrentLight = light
                    };

                    context.Show();
                    context.Turn();
                    context.Show();
                    context.Turn();
                    context.Show();
                    context.Turn();
                    context.Show();
                    context.Turn();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
