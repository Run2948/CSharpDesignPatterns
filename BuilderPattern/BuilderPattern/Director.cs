using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class Director
    {
        private AbstractBuilder _AbstractBuilder = null;
        public Director(AbstractBuilder builder)
        {
            this._AbstractBuilder = builder;
        }

        public Car GetCar()
        {
            this._AbstractBuilder.Engine();
            this._AbstractBuilder.Wheels();
            this._AbstractBuilder.Light();

            return this._AbstractBuilder.Car();
        }
    }
}
