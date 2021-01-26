using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 1 解释器模式InterpreterPattern
    /// 2 优缺点分析和使用场景
    /// 3 web开发模板替换的解释器模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训课，今天是Eleven老师为大家带来的解释器模式Interpreter");
                Console.WriteLine("********************************");
                string teacher = "Eleven";
                Console.WriteLine(ToNumberIf(teacher));
                Console.WriteLine(ToNumberCommon(teacher));
                Console.WriteLine("********************************");
                string student = "Gary";
                Console.WriteLine(ToNumberIf(student));
                Console.WriteLine(ToNumberCommon(student));


                Console.WriteLine(ToNumberCommon("ObjectIsNotFound"));
                Console.WriteLine("********************************");

                {
                    Context context = new Context("ObjectIsNotFound");
                    AIInterpreter interpreter = new AIInterpreter();
                    interpreter.Conversion(context);
                    Console.WriteLine(context.Get());
                }

                {
                    Context context = new Context("ObjectIsNotFound");
                    List<BaseInterpreter> interpreterList = new List<BaseInterpreter>()
                    {
                        new JNInterpreter(),
                        new AIInterpreter(),
                        new ZeroInterpreter()
                    };
                    foreach (var item in interpreterList)
                    {
                        item.Conversion(context);
                    }
                    Console.WriteLine(context.Get());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        /// <summary>
        /// a b c d e f g h i j k l m n....
        /// 1 2 3 4 5 6 7 8 9 0 0 0 0 0....
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ToNumberIf(string text)
        {
            if (text.Equals("Eleven"))
            {
                return "505050";
            }
            else if (text.Equals("Gary"))
            {
                return "7100";
            }
            else
                throw new Exception("wrong text");
        }

        /// <summary>
        /// a b c d e f g h i     j k l m n....
        /// 1 2 3 4 5 6 7 8 9     a b c d e....
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ToNumberCommon(string text)
        {
            if (string.IsNullOrEmpty(text))
                return "";
            List<string> numberList = new List<string>();
            //o t---j n
            //j n---a e
            //a i---1 9
            //other--0

            foreach (var item in text.ToLower().ToArray())
            {
                switch (item)
                {
                    case 'a':
                    case 'j':
                        numberList.Add("1");
                        break;
                    case 'b':
                    case 'k':
                        numberList.Add("2");
                        break;
                    case 'c':
                    case 'l':
                        numberList.Add("3");
                        break;
                    case 'd':
                    case 'm':
                        numberList.Add("4");
                        break;
                    case 'e':
                    case 'n':
                        numberList.Add("5");
                        break;
                    case 'f':
                        numberList.Add("6");
                        break;
                    case 'g':
                        numberList.Add("7");
                        break;
                    case 'h':
                        numberList.Add("8");
                        break;
                    case 'i':
                        numberList.Add("9");
                        break;
                    default:
                        numberList.Add("0");
                        break;
                }
            }
            return string.Concat(numberList);//数组链接成字符串
        }
    }
}
