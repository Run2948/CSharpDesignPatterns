using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 第三方提供的  openstack  servicestack
    /// 不能修改
    /// </summary>
    public class RedisHelper
    {
        public void AddRedis<T>()
        {
            Console.WriteLine("This is {0} Add", this.GetType().Name);
        }
        public void DeleteRedis<T>()
        {
            Console.WriteLine("This is {0} Delete", this.GetType().Name);
        }
        public void UpdateRedis<T>()
        {
            Console.WriteLine("This is {0} Update", this.GetType().Name);
        }
        public void QueryRedis<T>()
        {
            Console.WriteLine("This is {0} Query", this.GetType().Name);
        }
    }
}
