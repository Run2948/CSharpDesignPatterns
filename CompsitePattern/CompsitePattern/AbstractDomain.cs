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
    public abstract class AbstractDomain
    {
        public string Name { get; set; }
        public double Percent { get; set; }
        public abstract void Commission(double total);

        public abstract void AddChild(Domain domainChild);

    }
}
