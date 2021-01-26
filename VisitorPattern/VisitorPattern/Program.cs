using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    /// <summary>
    /// 1 集合的访问和访问者模式Visitor Pattern
    /// 2 倾斜的可扩展性设计
    /// 3 应用场景
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的访问者模式Visitor");
                List<Student> studentList = new List<Student>()
                {
                    new StudentVip()
                    {
                        Id=638,
                        Name="ME860"
                    },
                    new StudentVip()
                    {
                        Id=586,
                        Name="如果"
                    },
                    new StudentFree()
                    {
                        Id=123,
                        Name="鱼猫"
                    }
                };
                foreach (var student in studentList)
                {
                    Console.WriteLine("*************************");
                    student.Study();
                    ////还要看视频
                    //if (student is StudentVip)
                    //{
                    //    Console.WriteLine("免费获取全套的公开课视频代码合集");
                    //}
                    //else if (student is StudentFree)
                    //{
                    //    Console.WriteLine("只能获取当次课的公开课视频代码");
                    //}
                    student.GetVideo();

                }

                {
                    Console.WriteLine("*************VisitorCurrent************");
                    VisitorCurrent visitor = new VisitorCurrent();
                    foreach (var student in studentList)
                    {
                        Console.WriteLine("*************************");
                        student.Study();
                        student.GetVideoVisitor(visitor);
                    }
                }
                {
                    Console.WriteLine("*************VisitorPast************");
                    VisitorPast visitor = new VisitorPast();
                    foreach (var student in studentList)
                    {
                        Console.WriteLine("*************************");
                        student.Study();
                        student.GetVideoVisitor(visitor);
                    }
                }
                {
                    Console.WriteLine("*************VisitorTemp************");
                    VisitorTemp visitor = new VisitorTemp();
                    foreach (var student in studentList)
                    {
                        Console.WriteLine("*************************");
                        student.Study();
                        student.GetVideoVisitor(visitor);
                    }
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
