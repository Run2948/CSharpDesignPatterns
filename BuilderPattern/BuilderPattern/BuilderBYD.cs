using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 比亚迪工人
    /// </summary>
    public class BuilderBYD : AbstractBuilder
    {
        private Engine _Engine = null;
        private Wheels _Wheels = null;
        private Light _Light = null;

        public override void Engine()
        {
            this._Engine = new Engine()
            {
                Name = "_Engine"
            };

            Console.WriteLine("{0} build Engine", this.GetType().Name);
        }

        public override void Wheels()
        {
            this._Wheels = new Wheels()
            {
                Name = "_Wheels"
            };
            Console.WriteLine("{0} build Wheels", this.GetType().Name);
        }

        public override void Light()
        {
            this._Light = new Light()
            {
                Name = "_Light"
            };
            Console.WriteLine("{0} build Light", this.GetType().Name);
        }

        public override Car Car()
        {
            Console.WriteLine("组装 {0} {1} {2}", this._Engine, this._Light, this._Wheels);
            Console.WriteLine("{0} build 比亚迪*唐", this.GetType().Name);

            return new Car(this._Engine, this._Light, this._Wheels)
            {
                Name = "比亚迪*唐"
            };
        }
    }
}
