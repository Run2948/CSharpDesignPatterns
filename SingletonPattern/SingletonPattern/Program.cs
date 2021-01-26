using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 1 单例模式(单线程和多线程)
    /// 2 单例模式的三种写法
    /// 3 单例模式的优缺点和应用场景
    /// 
    /// 保证了整个进程中该对象只被实例化一次，
    /// 常驻内存
    /// 
    /// 普通的类型是需要的时候就初始化，用完被GC回收
    /// </summary>
    class Program
    {
        //public static Singleton singletonCommon = new Singleton();//只构造一个对象

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的单例模式Singleton");

                ////Singleton singleton = Singleton.CreateInstance(); //new Singleton();//只构造一个对象
                ////for (int i = 0; i < 10; i++)
                ////{
                ////    Singleton singleton = Singleton.CreateInstance();
                ////    Singleton singleton = new Singleton();//每次都构造一个对象
                ////    singletonCommon.Show();
                ////    singleton.Show();
                ////}

                ////StudentA.UseSingleton();
                ////StudentB.UseSingleton();
                ////StudentC.UseSingleton();

                List<IAsyncResult> resultList = new List<IAsyncResult>();
                for (int i = 0; i < 10; i++)
                {
                   resultList.Add( new Action(() =>
                    {
                        Singleton singleton = Singleton.CreateInstance();
                        singleton.Show();
                    }).BeginInvoke(null, null));//会启动一个异步多线程调用
                }

                while (resultList.Count(r => !r.IsCompleted) > 0)
                {
                    Thread.Sleep(10);
                }
                for (int i = 0; i < 10; i++)
                {
                    resultList.Add(new Action(() =>
                    {
                        SingletonSecond singleton = SingletonSecond.CreateInstance();
                        singleton.Show();
                    }).BeginInvoke(null, null));//会启动一个异步多线程调用
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
