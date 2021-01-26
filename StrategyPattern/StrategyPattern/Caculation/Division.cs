using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Caculation
{
    public class Division : BaseCaculation
    {
        public override int Cuculation(int iInputLeft, int iInputRight)
        {
            //Console.WriteLine("windows prepare:iInputLeft={0} iInputRight={1}", iInputLeft, iInputRight);
            
            if (iInputRight == 0)
            {
                Console.WriteLine("被除数是0，不合法");
                throw new Exception("被除数是0，不合法");
            }

            return iInputLeft / iInputRight;
        }
    }
}
