using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Mother : IObserver
    {
        public void Whisper()
        {
            Console.WriteLine("{0} Whisper", this.GetType().Name);
        }

        public void Action()
        {
            this.Whisper();
        }
    }
}
