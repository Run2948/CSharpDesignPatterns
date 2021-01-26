using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    /// <summary>
    /// 1 适配器模式概述
    /// 2 类适配器模式和对象适配器模式
    /// 3 适配器模式的应用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的适配器模式");
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new SqlserverHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new MysqlHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new OracleHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }

                Console.WriteLine("*****************************");
                {
                    IHelper helper = new RedisHelperClass(); //new RedisHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
                }
                {
                    RedisHelperClass helper = new RedisHelperClass();
                    helper.Add<Program>();
                }
                Console.WriteLine("*****************************");
                {
                    IHelper helper = new RedisHelperObject(); //new RedisHelper();
                    helper.Add<Program>();
                    helper.Delete<Program>();
                    helper.Update<Program>();
                    helper.Query<Program>();
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
