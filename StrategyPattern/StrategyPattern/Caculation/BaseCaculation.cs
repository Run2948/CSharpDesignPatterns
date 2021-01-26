using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Caculation
{
    public abstract class BaseCaculation
    {
        public abstract int Cuculation(int iInputLeft, int iInputRight);
    }
}
