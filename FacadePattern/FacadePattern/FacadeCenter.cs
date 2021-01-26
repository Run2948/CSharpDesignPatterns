using FacadePattern.Logistics;
using FacadePattern.Order;
using FacadePattern.Storage;
using FacadePattern.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    /// <summary>
    /// 门面模式 通常是单例的
    /// </summary>
    public class FacadeCenter
    {
        public class IdModel
        {
            public int Userid { get; set; }
            public int productId { get; set; }
            public int cityId { get; set; }
        }

        private static FacadeCenter _FacadeCenter = new FacadeCenter();
        private FacadeCenter()
        { }

        public static FacadeCenter CreateInstance()
        {
            return _FacadeCenter;
        }

        public void NewOrder(int userId, int productId, int cityId)
        {
            IUserSystem iUserSystem = new UserSystem("为什么");
            IStorageSystem iStorageSystem = new StorageSystem();
            ILogisticsSystem iLogisticsSystem = new LogisticsSystem();
            IOrderSystem iOrderSystem = new OrderSystem();

            if (!iUserSystem.CheckUser(userId))
            {
                Console.WriteLine("用户检测失败");
            }
            else if (!iStorageSystem.CheckStorage(productId))
            {
                Console.WriteLine("仓储检测失败");
            }
            else if (!iLogisticsSystem.CheckLogistics(productId, cityId))
            {
                Console.WriteLine("物流检测失败");
                //不能直接去物流增加一个检测失败的数据记录
                //而是通过物流系统的方法去做
            }
            else if (!iOrderSystem.CheckOrder(userId, productId))
            {
                Console.WriteLine("订单检测失败");
            }
            else
            {
                iOrderSystem.NewOrder(userId, productId);
                iLogisticsSystem.NewLogistics(productId, cityId);
            }
        }
    }
}
