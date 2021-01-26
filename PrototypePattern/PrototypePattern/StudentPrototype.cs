using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 原型类 
    /// </summary>
    [Serializable]
    public class StudentPrototype
    {
        private StudentPrototype()
        {
            Thread.Sleep(2000);
            long lResult = 0;
            for (int i = 0; i < 100000000; i++)
            {
                lResult += i;
            }
            Console.WriteLine("{0}被构造..", this.GetType().Name);
        }

        private static StudentPrototype _StudentPrototype = null;
        static StudentPrototype()
        {
            _StudentPrototype = new StudentPrototype()
            {
                Id = 337,
                Name = "歌神",
                Class = new Class()
                {
                    Num = 1,
                    Remark = "软谋高级班"
                }
            };
        }

        public static StudentPrototype CreateInstance()
        {
            StudentPrototype studentPrototype = (StudentPrototype)_StudentPrototype.MemberwiseClone();//浅克隆一个对象
            studentPrototype.Class = new Class()
                {
                    Num = 1,
                    Remark = "软谋高级班"
                };//这样就是深clone

            return studentPrototype;
        }

        public static StudentPrototype CreateInstanceSerialize()
        {
            return SerializeHelper.DeepClone<StudentPrototype>(_StudentPrototype);
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }
        public void Study()
        {
            Console.WriteLine("{0}在学习.net高级班公开课之设计模式特训", this.Name);
        }
    }

    /// <summary>
    /// 班级
    /// </summary>
    [Serializable]
    public class Class
    {
        public int Num { get; set; }
        public string Remark { get; set; }
    }

}
