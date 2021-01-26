using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class LightBase
    {
        public LightColor Color { get; set; }

        public void Shine()
        {
            Console.WriteLine("灯亮着");
        }
        public abstract void Show();
        public abstract void Turn();

        public abstract void TurnContext(Context context);
    }
}
