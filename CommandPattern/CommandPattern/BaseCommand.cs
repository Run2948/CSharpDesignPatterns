using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class BaseCommand
    {
        public Document _Document
        {
            get;
            private set;
        }

        public IReceiver _Receiver
        {
            get;
            private set;
        }

        //public BaseCommand(Document doc)
        //{
        //    this._Document = doc;
        //}

        public void Set(Document doc)
        {
            this._Document = doc;
        }

        public void SetReiceiver(IReceiver receiver)
        {
            this._Receiver = receiver;
        }


        public abstract void Excute();
    }
}
