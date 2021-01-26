using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    /// <summary>
    /// 第三方保存容器：txt xml db  缓存  内存
    /// </summary>
    public class Caretaker
    {
        //private static War3Memento _War3Memento = null;
        //public static void SaveWar3Memento(War3Memento war3Memento)
        //{
        //    _War3Memento = war3Memento;
        //}

        //public static War3Memento GetWar3Memento()
        //{
        //    return _War3Memento;
        //}


        private static Dictionary<string, War3Memento> _War3MementoDictionary = new Dictionary<string, War3Memento>();
        public static void SaveWar3Memento(string name, War3Memento war3Memento)
        {
            _War3MementoDictionary.Add(name, war3Memento);
        }

        public static War3Memento GetWar3Memento(string name)
        {
            if (_War3MementoDictionary.ContainsKey(name))
                return _War3MementoDictionary[name];
            else
                throw new Exception("wrong name");
        }
    }
}
