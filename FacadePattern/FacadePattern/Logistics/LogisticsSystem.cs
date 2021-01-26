using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Logistics
{
    public class LogisticsSystem : ILogisticsSystem
    {
        public bool CheckLogistics(int productId, int cityId)
        {
            //远程接口
            //本地缓存
            //搜索引擎
            return true;
        }
        public void NewLogistics(int productId, int cityId)
        {
            Console.WriteLine("{0}城市 商品{1}的物流订单", cityId, productId);
        }
    }
}
