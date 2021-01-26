using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonSecond
    {
        private SingletonSecond()
        {
            Thread.Sleep(1000);//耗时
            string bigSize = "占用10M内存";//耗计算资源
            string resource = "占用多个线程和数据库连接资源";//耗有限资源
            Console.WriteLine("{0}被构造，线程id={1}", this.GetType().Name, Thread.CurrentThread.ManagedThreadId);
        }

        private static SingletonSecond _Singleton = null;

        /// <summary>
        /// 静态构造函数：由CLR保证，在第一次使用这个类之前，调用而且只调用一次
        /// </summary>
        static SingletonSecond()
        {
            _Singleton = new SingletonSecond();
        }
        public static SingletonSecond CreateInstance()
        {
            return _Singleton;
        }






        public void Show()
        {
            Console.WriteLine("这里调用了{0}.Show", this.GetType().Name);
        }

    }
}
