using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 通过继承 类适配器模式
    /// </summary>
    public class RedisHelperClass : RedisHelper, IHelper
    {
        public void Add<T>()
        {
            base.AddRedis<T>();
        }

        public void Delete<T>()
        {
            base.DeleteRedis<T>();
        }

        public void Update<T>()
        {
            base.UpdateRedis<T>();
        }

        public void Query<T>()
        {
            base.QueryRedis<T>();
        }
    }
}
