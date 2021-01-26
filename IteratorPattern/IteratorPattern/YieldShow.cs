using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// http://www.cnblogs.com/YamatAmain/p/5016464.html
    /// 
    /// 含有yield的函数说明它是一个生成器，而不是普通的函数。当程序运行到yield这一行时，该函数会返回值，并保存当前域的所有变量状态；等到该函数下一次被调用时，会从上一次中断的地方开始执行，一直遇到下一个yield, 程序返回值, 并在此保存当前状态; 如此反复，直到函数正常执行完成。
    /// 
    /// 迭代器模式是设计模式中行为模式(behavioral pattern)的一个例子，他是一种简化对象间通讯的模式，也是一种非常容易理解和使用的模式。简单来说，迭代器模式使得你能够获取到序列中的所有元素 而不用关心是其类型是array，list，linked list或者是其他什么序列结构。这一点使得能够非常高效的构建数据处理通道(data pipeline)--即数据能够进入处理通道，进行一系列的变换，或者过滤，然后得到结果。事实上，这正是LINQ的核心模式。


    /// 在.NET中，迭代器模式被IEnumerator和IEnumerable及其对应的泛型接口所封装。如果一个类实现了IEnumerable接 口，那么就能够被迭代；调用GetEnumerator方法将返回IEnumerator接口的实现，它就是迭代器本身。迭代器类似数据库中的游标，他是 数据序列中的一个位置记录。迭代器只能向前移动，同一数据序列中可以有多个迭代器同时对数据进行操作。
    /// </summary>
    public class YieldShow
    {
        public IEnumerable<int> CreateEnumerable()
        {
            try
            {
                Console.WriteLine("{0} CreateEnumerable()方法开始", DateTime.Now);
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0}开始 yield {1}", DateTime.Now, i);
                    yield return i;
                    Console.WriteLine("{0}yield 结束", DateTime.Now);
                    if (i == 4)
                    {
                        yield break;//直接终结迭代  4会出现的，，
                    }
                }
                Console.WriteLine("{0} Yielding最后一个值", DateTime.Now);
                yield return -1;
                Console.WriteLine("{0} CreateEnumerable()方法结束", DateTime.Now);
            }
            finally
            {
                Console.WriteLine("停止迭代！");
            }
        }

        /// <summary>
        /// MoveNext 检查是否存在  并设置current
        /// </summary>
        public void Show()
        {
            IEnumerable<int> iterable = this.CreateEnumerable();//1 不会直接执行
            //IEnumerator iterator = iterable.GetEnumerator();
            IEnumerator<int> iterator = iterable.GetEnumerator();
            Console.WriteLine("开始迭代");
            while (true)
            {
                Console.WriteLine("调用MoveNext方法……");
                Boolean result = iterator.MoveNext();//2 正式开启CreateEnumerable
                Console.WriteLine("MoveNext方法返回的{0}", result);
                if (!result)
                {
                    break;
                }
                Console.WriteLine("获取当前值……");
                Console.WriteLine("获取到的当前值为{0}", iterator.Current);
            }
            Console.ReadKey();
        }
    }
}
