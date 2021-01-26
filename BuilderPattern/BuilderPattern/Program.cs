using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 1 Builder设计模式4大角色
    /// 2 和工厂模式的区别
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的建造者模式Builder");
                Console.WriteLine("**********************************");
                {
                    AbstractBuilder builder = new BuilderFord();
                    builder.Engine();
                    builder.Wheels();
                    builder.Light();

                    builder.Car();
                }
                Console.WriteLine("**********************************");
                {
                    AbstractBuilder builder = new BuilderBYD();
                    builder.Engine();
                    builder.Wheels();
                    builder.Light();

                    builder.Car();
                }
                Console.WriteLine("**********************************");
                {
                    AbstractBuilder builder = new BuilderBYD();

                    Director director = new Director(builder);
                    director.GetCar();
                }

                Console.WriteLine("**********************************");
                {
                    AbstractBuilder builder = new BuilderVolkswagen();
                    Director director = new Director(builder);
                    director.GetCar();
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
