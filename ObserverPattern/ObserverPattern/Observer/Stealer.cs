using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Stealer : IObserver
    {
        public void Hide()
        {
            Console.WriteLine("{0} Hide", this.GetType().Name);
        }

        public void Action()
        {
            this.Hide();
        }
    }
}
