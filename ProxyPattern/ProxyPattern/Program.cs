using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 1 代理模式Proxy
    /// 2 AOP：日志代理 异常代理 延迟代理 权限代理 单例代理 缓存代理 
    /// 3 封装：webservice orm
    /// 4 和适配器、装饰模式的区别
    /// 
    /// 任何技术问题都可以通过加一层来解决，
    /// 如果不行，就再加一层
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的代理模式");

                Console.WriteLine("********************");
                {
                    ISubject realSubject = new RealSubject();
                    Console.WriteLine("干点别的");
                    Console.WriteLine("干点别的");
                    Console.WriteLine("干点别的");
                    Console.WriteLine("干点别的");
                    realSubject.GetSomething();
                    realSubject.GetSomething();
                    realSubject.DoSomething();
                }
                Console.WriteLine("********************");
                {
                    ISubject proxySubject = new ProxySubject();


                    Console.WriteLine("干点别的");
                    Console.WriteLine("干点别的");
                    Console.WriteLine("干点别的");
                    Console.WriteLine("干点别的");

                    proxySubject.GetSomething();
                    proxySubject.GetSomething();
                    proxySubject.GetSomething();
                    proxySubject.GetSomething();
                    proxySubject.DoSomething();
                }

                ServiceReference1.SearcherClient client = new ServiceReference1.SearcherClient();
                //client.QueryCommodityPage();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
