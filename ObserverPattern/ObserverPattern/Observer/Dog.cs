using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Dog : IObserver
    {
        public void Wang(string name)
        {
            Console.WriteLine("{0} Wang", this.GetType().Name);
        }

        public void Action()
        {
            this.Wang("2");
        }
    }
}
