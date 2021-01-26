using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 单例类  
    /// </summary>
    public class StudentSingleton
    {
        private StudentSingleton()
        {
            Thread.Sleep(2000);
            long lResult = 0;
            for (int i = 0; i < 100000000; i++)
            {
                lResult += i;
            }
            Console.WriteLine("{0}被构造..", this.GetType().Name);
        }
        private static StudentSingleton _StudentSingleton = null;
        static StudentSingleton()
        {
            _StudentSingleton = new StudentSingleton()
            {
                Id = 479,
                Name = "悠悠吾心"
            };
        }

        public static StudentSingleton CreateInstance()
        {
            return _StudentSingleton;
        }

        


        public int Id { get; set; }
        public string Name { get; set; }
        public void Study()
        {
            Console.WriteLine("{0}在学习.net高级班公开课之设计模式特训", this.Name);
        }



    }
}
