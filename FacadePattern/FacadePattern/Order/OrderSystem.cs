using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Order
{
    public class OrderSystem : IOrderSystem
    {
        public bool CheckOrder(int userId, int productId)
        {
            return true;
        }
        public void NewOrder(int userId, int productId)
        {
            Console.WriteLine("{0}给商品{1}下订单", userId, productId);
        }
    }
}
