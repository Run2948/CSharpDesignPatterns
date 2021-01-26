using FactoryPattern.War3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.War3.ServiceExtend
{
    /// <summary>
    /// war3种族之一
    /// </summary>
    public class Five : IRace
    {
        public void ShowKing()
        {
            Console.WriteLine("The King of {0} is 悠悠吾心", this.GetType().Name);
        }
    }
}
