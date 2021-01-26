using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 使用foreach的条件是 类型包含public IEnumerator GetEnumerator()
    /// </summary>
    public class Food //: IEnumerable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new Exception();
            //返回一个迭代器
        }
    }
}
