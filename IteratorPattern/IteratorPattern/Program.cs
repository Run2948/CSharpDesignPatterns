using IteratorPattern.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 1 迭代器模式 Iterator
    /// 2 .net里面的迭代器模式  yield return
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的迭代器模式");
                {
                    Console.WriteLine("***********************KFCMenu*********************");
                    KFCMenu menu = new KFCMenu();
                    Food[] foods = menu.GetFoods();
                    for (int i = 0; i < foods.Length; i++)
                    {
                        Console.WriteLine("{0} {1} {2}￥", foods[i].Id, foods[i].Name, foods[i].Price);
                    }

                    IIterator<Food> iterator = menu.GetIterator();
                    while (iterator.MoveNext())
                    {
                        Food food = iterator.Current;
                        Console.WriteLine("{0} {1} {2}￥", food.Id, food.Name, food.Price);
                    }



                    //foreach (var item in foods)
                    //{
                    //    Console.WriteLine("{0} {1} {2}￥", item.Id, item.Name, item.Price);
                    //}
                }
                {
                    Console.WriteLine("***********************MacDonaldMenu*********************");
                    MacDonaldMenu menu = new MacDonaldMenu();
                    List<Food> foods = menu.GetFoods();
                    for (int i = 0; i < foods.Count; i++)
                    {
                        Console.WriteLine("{0} {1} {2}￥", foods[i].Id, foods[i].Name, foods[i].Price);
                    }

                    IIterator<Food> iterator = menu.GetIterator();
                    while (iterator.MoveNext())
                    {
                        Food food = iterator.Current;
                        Console.WriteLine("{0} {1} {2}￥", food.Id, food.Name, food.Price);
                    }



                    //foreach (var item in foods)
                    //{
                    //    Console.WriteLine("{0} {1} {2}￥", item.Id, item.Name, item.Price);
                    //}

                    //Food food = new Food();
                    //foreach (var item in food)
                    //{

                    //}


                }

                {
                    YieldShow show = new YieldShow();
                    show.Show();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
