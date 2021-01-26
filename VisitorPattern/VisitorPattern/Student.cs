using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    /// <summary>
    /// 学生
    /// </summary>
    public abstract class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long QQ { get; set; }

        public void Study()
        {
            Console.WriteLine("{0}跟着Eleven老师学习.net高级开发", this.Name);
        }

        public abstract void GetVideo();

        public abstract void GetVideoVisitor(IVisitor visitor);

        //public void GetVideo()
        //{
        //    if (this is StudentVip)
        //    {
        //        Console.WriteLine("免费获取全套的公开课视频代码合集");
        //    }
        //    else if (this is StudentFree)
        //    {
        //        Console.WriteLine("只能获取当次课的公开课视频代码");
        //    }
        //}
    }
}
