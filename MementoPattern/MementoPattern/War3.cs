using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 魔兽争霸
    /// </summary>
    public class War3
    {
        public string Race { get; set; }
        public string Hero { get; set; }
        public string Army { get; set; }
        public string Resource { get; set; }

        public void Show()
        {
            Console.WriteLine("********************************");
            Console.WriteLine("     Race:{0}", this.Race);
            Console.WriteLine("     Hero:{0}", this.Hero);
            Console.WriteLine("     Army:{0}", this.Army);
            Console.WriteLine("Resource:{0}", this.Resource);
            Console.WriteLine("********************************");
        }

        //public void Save()
        //{
        //    War3Memento memento = new War3Memento(this.Hero, this.Army, this.Resource);
        //    Caretaker.SaveWar3Memento(memento);
        //}

        //public void Load()
        //{
        //    War3Memento memento = Caretaker.GetWar3Memento();

        //    this.Army = memento.Army;
        //    this.Hero = memento.Hero;
        //    this.Resource = memento.Resource;
        //}

        public void Save(string name)
        {
            War3Memento memento = new War3Memento(this.Hero, this.Army, this.Resource);
            Caretaker.SaveWar3Memento(name, memento);
        }

        public void Load(string name)
        {
            War3Memento memento = Caretaker.GetWar3Memento(name);

            this.Army = memento.Army;
            this.Hero = memento.Hero;
            this.Resource = memento.Resource;
        }


    }
}
