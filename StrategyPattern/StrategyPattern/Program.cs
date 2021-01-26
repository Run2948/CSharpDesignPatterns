using StrategyPattern.Caculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 1 策略模式(Strategy)介绍和优缺点
    /// 2 策略模式和简单工厂的结合
    /// 3 策略模式的应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的策略模式");
                Console.WriteLine("下面是一个计算器展示demo：");
                while (true)
                {
                    Console.WriteLine("******************************");
                    Console.WriteLine("******************************");
                    Console.WriteLine("******************************");
                    #region 用户输入和校验  前端逻辑
                    int iInputLeft = 0;
                    int iInputRight = 0;
                    string operate = "";

                    Console.WriteLine("输入第一个数字(整数):");
                    string sInputLeft = Console.ReadLine();
                    if (!int.TryParse(sInputLeft, out iInputLeft))
                    {
                        Console.WriteLine("输入数字无效,请重新输入");
                        continue;
                    }

                    Console.WriteLine("输入计算符号(+-*/):");
                    operate = Console.ReadLine();
                    if (!new string[] { "+", "-", "*", "/" }.Contains(operate))
                    {
                        Console.WriteLine("输入计算符号无效,请重新输入");
                        continue;
                    }

                    Console.WriteLine("输入第二个数字(整数):");
                    string sInputRight = Console.ReadLine();
                    if (!int.TryParse(sInputRight, out iInputRight))
                    {
                        Console.WriteLine("输入数字无效,请重新输入");
                        continue;
                    }
                    #endregion

                    #region 具体计算 业务逻辑
                    int iResult = 0;
                    //switch (operate)
                    //{
                    //    case "+":
                    //        iResult = iInputLeft + iInputRight;
                    //        break;
                    //    case "-":
                    //        iResult = iInputLeft - iInputRight;
                    //        break;
                    //    case "*":
                    //        iResult = iInputLeft * iInputRight;
                    //        break;
                    //    case "/":
                    //        iResult = iInputLeft / iInputRight;//非0检测  每一个分支的逻辑可能很复杂
                    //        break;
                    //    default:
                    //        Console.WriteLine("输入符号异常,重新输入");
                    //        continue;
                    //}

                    //BaseCaculation baseCaculation = null;
                    //switch (operate)//就是把计算的逻辑封装到类里面，同时提供了抽象，好处就在于逻辑清晰，维护方便
                    //{
                    //    case "+":
                    //        baseCaculation = new Plus();
                    //        break;
                    //    case "-":
                    //        baseCaculation = new Minus();
                    //        break;
                    //    case "*":
                    //        baseCaculation = new Multiply();
                    //        break;
                    //    case "/":
                    //        baseCaculation = new Division();
                    //        break;
                    //    default:
                    //        Console.WriteLine("输入符号异常,重新输入");
                    //        continue;
                    //}
                    BaseCaculation baseCaculation = SimpleFactory.CreateCaculation(operate);

                    //iResult = baseCaculation.Cuculation(iInputLeft, iInputRight);
                    Context context = new Context(iInputLeft, iInputRight, baseCaculation);
                    iResult = context.Caculation();

                    Console.WriteLine("计算为: {0}{1}{2}={3}", iInputLeft, operate, iInputRight, iResult);
                    #endregion
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
