using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    /// <summary>
    /// 1 命令模式介绍和例子
    /// 2 命令模式实现异步队列
    /// 3 数据恢复、命令撤销
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的命令模式");

                Document document = new Document();
                document.Read();//直接出票，需要10s计算
                document.Write();

                Console.WriteLine("*************");
                Console.WriteLine("Input r w ");
                while (true)
                {
                    string input = Console.ReadLine();

                    //if (input.Equals("r"))
                    //    document.Read();
                    //else if (input.Equals("w"))
                    //    document.Write();
                    //else
                    //    Console.WriteLine("do noting,reinput");


                    string action = ConfigurationManager.AppSettings[input];
                    //if (action.Equals("read"))
                    //    document.Read();
                    //else if (action.Equals("write"))
                    //    document.Write();
                    //else
                    //    Console.WriteLine("do noting,reinput");

                    BaseCommand command = (BaseCommand)Activator.CreateInstance(action.Split(',')[1], action.Split(',')[0]).Unwrap();
                    //保存了一个买票的命令，然后告诉用户在排队了



                    //后台在运行，给你指定票或者没有票
                    IReceiver receiver = new ReceiverNew();//也可以配置+反射
                    command.SetReiceiver(receiver);
                    command.Set(document);
                    //command.Excute();

                    Invoker invoker = new Invoker(command);
                    invoker.Excute();


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
