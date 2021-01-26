using ObserverPattern.Observer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    /// <summary>
    /// 1 观察者模式Observer
    /// 2 .net的委托事件
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的观察者模式");

                {
                    Cat cat = new Cat();
                    cat.Miao();

                    Console.WriteLine("*************Observer***************");
                    {
                        Brother brother = new Brother();

                        cat.AddObserver(new Mouse());
                        cat.AddObserver(new Dog());
                        cat.AddObserver(new Cricket());
                        cat.AddObserver(new Baby());
                        cat.AddObserver(new Father());
                        cat.AddObserver(new Mother());
                        cat.AddObserver(brother);
                        cat.AddObserver(new Neighbor());
                        cat.AddObserver(new Stealer());

                        cat.MiaoObserver();

                        cat.RemoveObserver(brother);
                        cat.MiaoObserver();
                    }
                    {
                        Console.WriteLine("*************Event***************");

                        Brother brother = new Brother();

                        cat.CatMiaoEvent += new Mouse().Run;
                        cat.CatMiaoEvent += () => new Dog().Wang("3");
                        cat.CatMiaoEvent += new Cricket().Sing;
                        cat.CatMiaoEvent += new Baby().Cry;
                        cat.CatMiaoEvent += new Father().Roar;
                        cat.CatMiaoEvent += new Mother().Whisper;
                        cat.CatMiaoEvent += brother.Turn;
                        cat.CatMiaoEvent += new Neighbor().Awake;
                        cat.CatMiaoEvent += new Stealer().Hide;
                        if (true)
                        {
                            AddDog(cat);
                        }

                        cat.MiaoEvent();

                        cat.CatMiaoEvent -= brother.Turn;

                        cat.MiaoEvent();
                    }
                }
                {
                    Console.WriteLine("*************Another Cat***************");
                    Cat cat = new Cat();

                    Brother brother = new Brother();

                    cat.AddObserver(new Baby());
                    cat.AddObserver(new Father());
                    cat.AddObserver(new Mother());
                    cat.AddObserver(brother);
                    cat.AddObserver(new Neighbor());

                    cat.MiaoObserver();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        private static void AddDog(Cat cat)
        {

        }

    }
}
