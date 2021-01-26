using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject
{
    /// <summary>
    /// 事情起源
    /// 大半夜，猫叫一声
    /// 
    /// baby cry
    /// dog wang
    /// father roar
    /// mother whisper
    /// .
    /// .
    /// .
    /// </summary>
    public class Cat
    {
        public void Miao()
        {
            Console.WriteLine("{0} Miao 一声", this.GetType().Name);
            //一系列后续动作

            new Mouse().Run();
            new Dog().Wang("1");
            new Baby().Cry();
            //new Dog().Wang();
            new Father().Roar();
            new Mother().Whisper();
            new Brother().Turn();
            new Neighbor().Awake();
            new Stealer().Hide();
            //new Cricket().Sing();
        }

        public Cat()
        { }
        public Cat(List<IObserver> observerList)
        {
            this._ObserverList = observerList;
        }



        private List<IObserver> _ObserverList = new List<IObserver>();

        public void AddObserver(IObserver observer)
        {
            this._ObserverList.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this._ObserverList.Remove(observer);
        }

        public void MiaoObserver()
        {
            Console.WriteLine("{0} MiaoObserver 一声", this.GetType().Name);
            //一系列后续动作
            foreach (var observer in this._ObserverList)
            {
                observer.Action();
            }
        }



        public event Action CatMiaoEvent;
        public void MiaoEvent()
        {
            Console.WriteLine("{0} MiaoEvent 一声", this.GetType().Name);
            if (this.CatMiaoEvent != null)
            {
                CatMiaoEvent.Invoke();
            }
        }

    }
}
