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
    /// 1 门面模式 Facade
    /// 2 门面模式和分层架构
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的门面模式");
                //模拟一个业务场景：用户需要登陆检测，然后检测库存、物流，订单，然后才能下单
                int userId = 123;
                int productId = 12345;
                int cityId = 1;

                FacadeCenter facadeCenter = FacadeCenter.CreateInstance();// new FacadeCenter();
                facadeCenter.NewOrder(userId, productId, cityId);

                {
                    //IUserSystem iUserSystem = new UserSystem();
                    //IStorageSystem iStorageSystem = new StorageSystem();
                    //ILogisticsSystem iLogisticsSystem = new LogisticsSystem();
                    //IOrderSystem iOrderSystem = new OrderSystem();

                    //if (!iUserSystem.CheckUser(userId))
                    //{
                    //    Console.WriteLine("用户检测失败");
                    //}
                    //else if (!iStorageSystem.CheckStorage(productId))
                    //{
                    //    Console.WriteLine("仓储检测失败");
                    //}
                    //else if (!iLogisticsSystem.CheckLogistics(productId, cityId))
                    //{
                    //    Console.WriteLine("物流检测失败");
                    //}
                    //else if (!iOrderSystem.CheckOrder(userId, productId))
                    //{
                    //    Console.WriteLine("订单检测失败");
                    //}
                    //else
                    //{
                    //    iOrderSystem.NewOrder(userId, productId);
                    //    iLogisticsSystem.NewLogistics(productId, cityId);
                    //}
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
