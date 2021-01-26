using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public abstract class BaseInterpreter
    {
        public abstract void Conversion(Context context);
    }
}
