using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ReadCommand : BaseCommand
    {

        //public ReadCommand(Document doc)
        //    : base(doc)
        //{

        //}


        public override void Excute()
        {
            //log
            this._Receiver.Read();
            //Console.WriteLine("Read");
        }
    }
}
