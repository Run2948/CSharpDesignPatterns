using FactoryPattern.War3.Interface;
using FactoryPattern.War3.Service;
using FactoryPattern.War3.ServiceExtend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 1 对比简单工厂，建立工厂方法(FactoryMethod)
    /// 2 工厂方法的优缺点和应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的工厂方法设计模式");
                {
                    Human human = new Human();
                    Undead undead = new Undead();
                    NE ne = new NE();
                    ORC orc = new ORC();

                    //Six six=new Six()//参数信息很麻烦

                }
                {
                    IRace human = new Human();
                    IRace undead = new Undead();
                    IRace ne = new NE();
                    IRace orc = new ORC();
                }
                {
                    IFactory humanFactory = new HumanFactory();
                    IRace human = humanFactory.CreateInstance();

                    IFactory fiveFactory = new FiveFactory();
                    IRace five = fiveFactory.CreateInstance();

                    IFactory sixFactory = new SixFactoryExtend();// new SixFactory();

                    IRace six = sixFactory.CreateInstance();
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
