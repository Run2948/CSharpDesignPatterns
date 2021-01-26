using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Mouse : IObserver
    {
        public void Run()
        {
            Console.WriteLine("{0} Run", this.GetType().Name);
        }

        public void Action()
        {
            this.Run();
        }
    }
}
