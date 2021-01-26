using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Menu
{
    public class KFCMenu
    {
        private Food[] _FoodList = new Food[3];

        public KFCMenu()
        {
            this._FoodList[0] = new Food()
            {
                Id = 1,
                Name = "汉堡包",
                Price = 15
            };
            this._FoodList[1] = new Food()
            {
                Id = 2,
                Name = "可乐",
                Price = 10
            };
            this._FoodList[2] = new Food()
            {
                Id = 3,
                Name = "薯条",
                Price = 8
            };
        }

        public Food[] GetFoods()
        {
            return this._FoodList;
        }


        public IIterator<Food> GetIterator()
        {
            return new KFCMenuIterator(this);
        }

    }
}
