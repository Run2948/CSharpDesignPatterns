using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// 1  建立一个享元模式（Flyweight）
    /// 2  和单例模式的区别
    /// 3  享元模式在.net里面的应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的享元模式");

                string vipTeacher = "Eleven";//引用类型
                string freeTeacher = "Eleven";//引用类型

                Console.WriteLine("vipTeacher==freeTeacher?                        {0}", vipTeacher == freeTeacher);//比较值
                Console.WriteLine("vipTeacher.Equals(freeTeacher)?                 {0}", vipTeacher.Equals(freeTeacher));//比较的也是值
                Console.WriteLine("object.ReferenceEquals(vipTeacher, freeTeacher)?{0}", object.ReferenceEquals(vipTeacher, freeTeacher));//比较的是引用

                string newTeacher = string.Format("Ele{0}", "ven");

                //string newTeacher2 = "Ele" + "ven";

                Console.WriteLine("vipTeacher==newTeacher?                        {0}", vipTeacher == newTeacher);//比较值
                Console.WriteLine("vipTeacher.Equals(newTeacher)?                 {0}", vipTeacher.Equals(newTeacher));//比较的也是值
                Console.WriteLine("object.ReferenceEquals(vipTeacher, newTeacher)?{0}", object.ReferenceEquals(vipTeacher, newTeacher));//比较的是引用




                //BaseWord e1 = new E();
                //BaseWord l = new L();
                ////BaseWord e2 = new E();
                //BaseWord v = new V();
                ////BaseWord e3 = new E();
                //BaseWord n = new N();

                //Show();
                //ShowEleven();

                E e = new E();

                new Action(Show).BeginInvoke(null, null);
                new Action(ShowEleven).BeginInvoke(null, null);



                Singleton singleton = Singleton.CreateInstance(); //new Singleton();
                Singleton singleton1 = Singleton.CreateInstance();
                Singleton singleton2 = Singleton.CreateInstance();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        //private static BaseWord e1 = new E();
        //private static BaseWord l = new L();
        //private static BaseWord v = new V();
        //private static BaseWord n = new N();
        /// <summary>
        /// 张三
        /// </summary>
        private static void Show()
        {
            Console.WriteLine("**********张三********");
            //BaseWord e1 = new E();
            //BaseWord l = new L();
            ////BaseWord e2 = new E();
            //BaseWord v = new V();
            ////BaseWord e3 = new E();
            //BaseWord n = new N();

            BaseWord e1 = FlyweightFactory.GetWord(WordType.E);
            BaseWord l = FlyweightFactory.GetWord(WordType.L);
            //BaseWord e2 = new E();
            BaseWord v = FlyweightFactory.GetWord(WordType.V);
            //BaseWord e3 = new E();
            BaseWord n = FlyweightFactory.GetWord(WordType.N);

            Console.WriteLine("{0}{1}{2}{3}{4}{5}",
                e1.Display(), l.Display(),
                e1.Display(), v.Display(),
                e1.Display(), n.Display());
            //e2.Display(),v.Display(),
            //e3.Display(),n.Display());

        }

        /// <summary>
        /// 李四
        /// </summary>
        private static void ShowEleven()
        {
            Console.WriteLine("**********李四********");
            //BaseWord e1 = new E();
            //BaseWord l = new L();
            ////BaseWord e2 = new E();
            //BaseWord v = new V();
            ////BaseWord e3 = new E();
            //BaseWord n = new N();

            BaseWord e1 = FlyweightFactory.GetWord(WordType.E);
            BaseWord l = FlyweightFactory.GetWord(WordType.L);
            //BaseWord e2 = new E();
            BaseWord v = FlyweightFactory.GetWord(WordType.V);
            //BaseWord e3 = new E();
            BaseWord n = FlyweightFactory.GetWord(WordType.N);

            Console.WriteLine("{0}{1}{2}{3}{4}{5}",
                e1.Display(), l.Display(),
                e1.Display(), v.Display(),
                e1.Display(), n.Display());
            //e2.Display(),v.Display(),
            //e3.Display(),n.Display());

        }
    }
}
