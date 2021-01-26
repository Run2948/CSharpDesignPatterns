using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        public LightBase CurrentLight { get; set; }

        public void Show()
        {
            this.CurrentLight.Show();
        }

        public void Turn()
        {
            this.CurrentLight.TurnContext(this);
        }
    }
}
