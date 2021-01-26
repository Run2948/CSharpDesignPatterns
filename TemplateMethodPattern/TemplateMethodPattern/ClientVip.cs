using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    /// <summary>
    /// 银行客户端
    /// </summary>
    public class ClientVip : Client
    {
        /// <summary>
        /// 活期  定期  利率不同
        /// </summary>
        /// <param name="balance"></param>
        /// <returns></returns>
        public override double CalculateInterest(double balance)
        {
            return balance * 0.005;
        }

        public override void Show(string name, double balance, double interest)
        {
            Console.WriteLine("尊贵的{0} vip客户，您的账户余额为：{1}，利息为{2}",
                name, balance, interest);
        }
    }
}
