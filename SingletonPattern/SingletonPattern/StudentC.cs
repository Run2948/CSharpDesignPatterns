using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class StudentC
    {
        public static void UseSingleton()
        {
            Console.WriteLine("This is StudentC");
            Singleton singleton = Singleton.CreateInstance();// new Singleton();
            singleton.Show();
        }
    }
}
