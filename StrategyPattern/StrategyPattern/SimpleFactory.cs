using StrategyPattern.Caculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SimpleFactory
    {
        public static BaseCaculation CreateCaculation(string operate)
        {

            BaseCaculation baseCaculation = null;
            switch (operate)//就是把计算的逻辑封装到类里面，同时提供了抽象，好处就在于逻辑清晰，维护方便
            {
                case "+":
                    baseCaculation = new Plus();
                    break;
                case "-":
                    baseCaculation = new Minus();
                    break;
                case "*":
                    baseCaculation = new Multiply();
                    break;
                case "/":
                    baseCaculation = new Division();
                    break;
                default:
                    Console.WriteLine("输入符号异常,重新输入");
                    throw new Exception("输入符号异常,重新输入");
            }
            //配置+反射
            return baseCaculation;
        }
    }
}
