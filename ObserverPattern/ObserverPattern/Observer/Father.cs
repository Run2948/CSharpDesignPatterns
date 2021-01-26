using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Father : IObserver
    {
        public void Roar()
        {
            Console.WriteLine("{0} Roar", this.GetType().Name);
        }

        public void Action()
        {
            this.Roar();
        }
    }
}
