using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Neighbor : IObserver
    {
        public void Awake()
        {
            Console.WriteLine("{0} Awake", this.GetType().Name);
        }

        public void Action()
        {
            this.Awake();
        }
    }
}
