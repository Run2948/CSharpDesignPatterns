using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Menu
{
    public class MacDonaldMenu
    {
        private List<Food> _FoodList = new List<Food>();

        public MacDonaldMenu()
        {
            this._FoodList.Add(new Food()
            {
                Id = 1,
                Name = "鸡肉卷",
                Price = 15
            });
            this._FoodList.Add( new Food()
            {
                Id = 2,
                Name = "红豆派",
                Price = 10
            });
            this._FoodList.Add(new Food()
            {
                Id = 3,
                Name = "薯条",
                Price = 9
            });
        }

        public List<Food> GetFoods()
        {
            return this._FoodList;
        }

        public IIterator<Food> GetIterator()
        {
            return new MacDonaldMenuIterator(this);
        }
    }
}
