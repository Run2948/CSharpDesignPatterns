using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MysqlHelper : IHelper
    {
        public void Add<T>()
        {
            Console.WriteLine("This is {0} Add", this.GetType().Name);
        }
        public void Delete<T>()
        {
            Console.WriteLine("This is {0} Delete", this.GetType().Name);
        }
        public void Update<T>()
        {
            Console.WriteLine("This is {0} Update", this.GetType().Name);
        }
        public void Query<T>()
        {
            Console.WriteLine("This is {0} Query", this.GetType().Name);
        }
    }
}
