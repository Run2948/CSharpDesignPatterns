
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Invoker
    {
        private BaseCommand _BaseCommand = null;//可以换成多个命令的集合

        public Invoker(BaseCommand baseCommand)
        {
            this._BaseCommand = baseCommand;
        }

        public void Excute()
        {
            this._BaseCommand.Excute();
        }

    }
}
