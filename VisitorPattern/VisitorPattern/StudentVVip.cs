using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    public class StudentVVip : Student
    {
        public string CourseFree { get; set; }
        public string CourseVip { get; set; }

        public override void GetVideo()
        {
            //if()
            //{}
            //else if()
            //{}
            //else{}
            Console.WriteLine("免费获取全套的公开课视频代码合集");
        }

        public override void GetVideoVisitor(IVisitor visitor)
        {
            //visitor.GetVideoVVip(this);//this 是当前的实例
        }


        //再建立多个方法  每个方法对应一种方式
        //再建立一堆的子类  分别去完成


    }
}
