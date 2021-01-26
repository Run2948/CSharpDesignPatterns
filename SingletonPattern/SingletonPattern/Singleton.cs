using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    /// <summary>
    /// 私有化构造函数
    /// 私有的静态变量
    /// 一个静态的对象创建方法
    /// 
    /// 
    /// </summary>
    public class Singleton
    {
        private Singleton()
        {
            Thread.Sleep(1000);//耗时
            string bigSize = "占用10M内存";//耗计算资源
            string resource = "占用多个线程和数据库连接资源";//耗有限资源
            Console.WriteLine("{0}被构造，线程id={1}", this.GetType().Name, Thread.CurrentThread.ManagedThreadId);
        }

        private static Singleton _Singleton = null;
        private static object Singleton_Lock = new object();

        public static Singleton CreateInstance()
        {
            if (_Singleton == null)//保证对象初始化之后的所有线程，不需要等待锁
            {
                Console.WriteLine("准备进入lock");
                lock (Singleton_Lock)//保证只有一个线程进去判断
                {
                    //Thread.Sleep(1000);
                    if (_Singleton == null)//保证对象为空才真的创建
                    {
                        _Singleton = new Singleton();
                    }
                }
            }
            return _Singleton;
        }






        public void Show()
        {
            Console.WriteLine("这里调用了{0}.Show", this.GetType().Name);
        }

    }
}
