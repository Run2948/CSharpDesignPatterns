using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class SaveCommand : BaseCommand
    {

        //public WriteCommand(Document doc)
        //    : base(doc)
        //{

        //}


        public override void Excute()
        {
            this._Receiver.Save();
            //Console.WriteLine("Save");
        }
    }
}
