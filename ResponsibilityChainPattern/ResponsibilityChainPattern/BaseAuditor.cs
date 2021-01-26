using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    public abstract class BaseAuditor
    {
        public BaseAuditor _NextAudtitor { get; private set; }

        public void SetNext(BaseAuditor nextAuditor)
        {
            this._NextAudtitor = nextAuditor;
        }




        public string Name { get; set; }

        public abstract void Audit(ApplyContext context);

    }
}
