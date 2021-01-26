using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    /// <summary>
    /// 1 简单工厂模式SimpleFactory
    /// 2 简单工厂+ 配置文件=可配置
    /// 3 简单工厂+ 配置文件+反射=可配置可扩展
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的简单工厂模式");

                Player uu = new Player()
                {
                    Id = 11,
                    Name = "Nine(479-悠悠吾心-女-合肥)"
                };
                {
                    Human human = new Human();
                    Undead undead = new Undead();
                    NE ne = new NE();
                    ORC orc = new ORC();

                    uu.PlayHuman(human);
                    uu.PlayUndead(undead);

                    uu.PlayWar3(human);
                    uu.PlayWar3(undead);
                    uu.PlayWar3(ne);
                    uu.PlayWar3(orc);
                }
                Console.WriteLine("*******************CreateInstance********************");
                {
                    IRace human = ObjectFactory.CreateInstance(RaceType.Human);// new Human();
                    IRace undead = ObjectFactory.CreateInstance(RaceType.Undead);// new Undead();
                    IRace ne = ObjectFactory.CreateInstance(RaceType.NE);// new NE();
                    IRace orc = ObjectFactory.CreateInstance(RaceType.ORC); //new ORC();


                    uu.PlayWar3(human);
                    uu.PlayWar3(undead);
                    uu.PlayWar3(ne);
                    uu.PlayWar3(orc);


                }
                Console.WriteLine("*****************CreateInstanceConfig********************");
                {
                    IRace race = ObjectFactory.CreateInstanceConfig();
                    uu.PlayWar3(race);
                }
                Console.WriteLine("*****************CreateInstanceConfigReflection********************");
                {
                    IRace race = ObjectFactory.CreateInstanceConfigReflection();
                    uu.PlayWar3(race);
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
