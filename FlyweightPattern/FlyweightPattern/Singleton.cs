using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 单例保证整个进程中，该类型只有一个实例
    /// </summary>
    public class Singleton
    {
        private Singleton()
        { 
        
        }

        private static Singleton _Singleton = null;

        static Singleton()
        {
            _Singleton = new Singleton();
        }

        public static Singleton CreateInstance()
        {
            return _Singleton;
        }


    }
}
