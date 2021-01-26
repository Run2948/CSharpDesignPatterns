using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Cricket : IObserver
    {
        public void Sing()
        {
            Console.WriteLine("{0} Sing", this.GetType().Name);
        }

        public void Action()
        {
            this.Sing();
        }
    }
}
