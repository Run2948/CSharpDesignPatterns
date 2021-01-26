using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Caculation
{
    public class Multiply : BaseCaculation
    {
        public override int Cuculation(int iInputLeft, int iInputRight)
        {
            //Console.WriteLine("windows prepare:iInputLeft={0} iInputRight={1}", iInputLeft, iInputRight);
            
            return iInputLeft * iInputRight;
        }
    }
}
