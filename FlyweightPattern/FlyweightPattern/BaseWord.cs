using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    public abstract class BaseWord
    {
        public int Id { get; set; }
        public string Remark { get; set; }
        public DateTime CreateTime { get; set; }
        public abstract string Display();
    }
}
