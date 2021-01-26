using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingletonThird
    {
        private SingletonThird()
        {
            Thread.Sleep(1000);//耗时
            string bigSize = "占用10M内存";//耗计算资源
            string resource = "占用多个线程和数据库连接资源";//耗有限资源
            Console.WriteLine("{0}被构造，线程id={1}", this.GetType().Name, Thread.CurrentThread.ManagedThreadId);
        }

        /// <summary>
        /// 静态变量：会在类型第一次使用的时候初始化，而且只初始化一次
        /// </summary>
        private static SingletonThird _Singleton = new SingletonThird();

        public static SingletonThird CreateInstance()
        {
            return _Singleton;
        }






        public void Show()
        {
            Console.WriteLine("这里调用了{0}.Show", this.GetType().Name);
        }

    }
}
