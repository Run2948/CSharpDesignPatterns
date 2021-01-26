using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompsitePattern
{
    /// <summary>
    /// 机构/个人
    /// </summary>
    public class DomainLeaf : AbstractDomain
    {
        public override void Commission(double total)
        {
            double result = total * this.Percent / 100;
            Console.WriteLine("this {0} 提成 {1}", this.Name, result);
        }

        public override void AddChild(Domain domainChild)
        {
            throw new Exception("这里不能AddChild");
        }
    }
}
