using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 通过组合  对象适配器模式
    /// 
    /// 组合优于继承
    /// </summary>
    public class RedisHelperObject : IHelper
    {
        //private RedisHelper _RedisHelper = new RedisHelper();
        private RedisHelper _RedisHelper = null;
        public RedisHelperObject(RedisHelper redisHelper)
        {
            this._RedisHelper = redisHelper;
        }

        public RedisHelperObject()
        {
            this._RedisHelper = new RedisHelper();
        }

        public void Add<T>()
        {
            this._RedisHelper.AddRedis<T>();
        }

        public void Delete<T>()
        {
            this._RedisHelper.DeleteRedis<T>();
        }

        public void Update<T>()
        {
            this._RedisHelper.UpdateRedis<T>();
        }

        public void Query<T>()
        {
            this._RedisHelper.QueryRedis<T>();
        }
    }
}
