using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Menu
{
    /// <summary>
    /// 新的集合  实现了IIterator接口
    /// </summary>
    public class KFCMenuIterator : IIterator<Food>
    {
        private Food[] _FoodList = null;

        public KFCMenuIterator(KFCMenu menu)
        {
            this._FoodList = menu.GetFoods();
        }

        private int _Index = -1;
        public Food Current
        {
            get
            {
                return this._FoodList[_Index];
            }
        }

        public bool MoveNext()
        {
            return this._FoodList.Length > ++this._Index;
        }

        public void Reset()
        {
            this._Index = -1;
        }
    }
}
