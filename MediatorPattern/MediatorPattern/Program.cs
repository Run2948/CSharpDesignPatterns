using MediatorPattern.Character;
using MediatorPattern.Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 1 中介者模式（Mediator Pattern）
    /// 2 中介者模式的优缺点和应用
    /// 3 数据库设计的中介者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的中介者模式");

                BaseCharacter teacher = new Teacher()
                {
                    Name = "Eleven"
                };

                BaseCharacter master = new Master()
                {
                    Name = "落单的候鸟"
                };


                BaseCharacter student1 = new Student()
                {
                    Name = "yoyo"
                };
                BaseCharacter student2 = new Student()
                {
                    Name = "小昶"
                };
                BaseCharacter student3 = new Student()
                {
                    Name = "木偶"
                };
                BaseCharacter student4 = new Student()
                {
                    Name = "一点半"
                };
                BaseCharacter student5 = new Student()
                {
                    Name = "初出茅庐"
                };
                Console.WriteLine("*********************************");

                teacher.SendMessage("今天晚上八点上课啦，，", master);
                Console.WriteLine("*********************************");
                master.SendMessage("老师，收到，马上通知大家", teacher);
                Console.WriteLine("*********************************");
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student1);
                Console.WriteLine("*********************************");

                //候鸟需要发消息给全部的学员
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student2);
                Console.WriteLine("*********************************");
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student3);
                Console.WriteLine("*********************************");
                master.SendMessage("今天晚上八点上课，大家不要错过哦", student4);
                Console.WriteLine("*********************************");
                Console.WriteLine("*********************************");
                Console.WriteLine("*********************************");

                {
                    BaseMediator mediator = new BaseMediator();
                    mediator.AddCharacter(master);
                    mediator.AddCharacter(student1);

                    mediator.SendMessage("今天晚上八点上课，大家不要错过哦", master);

                    Console.WriteLine("*********************************");

                    mediator.SendMessage("收到，一定准时前来", student4);
                }

                {
                    BaseMediator mediator = new BaseMediator();
                    mediator.AddCharacter(teacher);
                    mediator.AddCharacter(master);
                    mediator.AddCharacter(student1);
                    mediator.AddCharacter(student2);
                    mediator.AddCharacter(student3);
                    mediator.AddCharacter(student4);
                    mediator.AddCharacter(student5);

                    mediator.SendMessage("今天晚上八点上课，大家不要错过哦", master);

                    Console.WriteLine("*********************************");

                    mediator.SendMessage("收到，一定准时前来", student4);
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
