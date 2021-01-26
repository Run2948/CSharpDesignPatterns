using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 1 单例模式/原型模式
    /// 2 浅克隆VS深克隆
    /// 3 原型模式的应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的原型模式PrototypePattern");
                //Console.WriteLine("***************************");
                //for (int i = 0; i < 5; i++)
                //{
                //    Student student = new Student()
                //    {
                //        Id = 530,
                //        Name = "530-小昶-女-海口"
                //    };
                //    student.Study();
                //}
                //Console.WriteLine("***************************");
                //for (int i = 0; i < 5; i++)
                //{
                //    StudentSingleton student = StudentSingleton.CreateInstance();
                //    student.Study();
                //}
                //Console.WriteLine("***************************");
                //for (int i = 0; i < 5; i++)
                //{
                //    StudentPrototype student = StudentPrototype.CreateInstance();
                //    student.Study();
                //}
                Console.WriteLine("**********************************");
                {
                    StudentSingleton student1 = StudentSingleton.CreateInstance();
                    StudentSingleton student2 = StudentSingleton.CreateInstance();

                    student1.Id = 506;
                    student1.Name = "yoyo";
                    Console.WriteLine("Id {0} Name {1}", student1.Id, student1.Name);
                    Console.WriteLine("Id {0} Name {1}", student2.Id, student2.Name);
                }

                Console.WriteLine("**********************************");
                {
                    StudentPrototype student1 = StudentPrototype.CreateInstance();
                    StudentPrototype student2 = StudentPrototype.CreateInstance();

                    student1.Id = 387;
                    student1.Name = "天道无情";//==new String("天道无情")
                    Console.WriteLine("Id {0} Name {1}", student1.Id, student1.Name);
                    Console.WriteLine("Id {0} Name {1}", student2.Id, student2.Name);

                    student1.Class.Num = 2;
                    student1.Class.Remark = "特训班";
                    //student1.Class = new Class()
                    //{
                    //    Num = 2,
                    //    Remark = "特训班"
                    //};

                    Console.WriteLine("Class.Num {0} Class.Remark {1}", student1.Class.Num, student1.Class.Remark);
                    Console.WriteLine("Class.Num {0} Class.Remark {1}", student2.Class.Num, student2.Class.Remark);
                }

                Console.WriteLine("**********************************");
                {
                    StudentPrototype student1 = StudentPrototype.CreateInstanceSerialize();
                    StudentPrototype student2 = StudentPrototype.CreateInstanceSerialize();

                    student1.Id = 387;
                    student1.Name = "天道无情";//==new String("天道无情")
                    Console.WriteLine("Id {0} Name {1}", student1.Id, student1.Name);
                    Console.WriteLine("Id {0} Name {1}", student2.Id, student2.Name);

                    student1.Class.Num = 2;
                    student1.Class.Remark = "特训班";

                    Console.WriteLine("Class.Num {0} Class.Remark {1}", student1.Class.Num, student1.Class.Remark);
                    Console.WriteLine("Class.Num {0} Class.Remark {1}", student2.Class.Num, student2.Class.Remark);
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
