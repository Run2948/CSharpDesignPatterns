using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitor;

namespace VisitorPattern
{
    public class StudentFree : Student
    {
        public string CourseFree { get; set; }

        /// <summary>
        /// 公开课学员  在不同的时间段，获取权限不同
        /// 1  只有代码没有视频
        /// 2  根据暗号获取当次课的视频
        /// 3  找助教获取当次课的视频
        /// </summary>
        public override void GetVideo()
        {
            //if()
            //{}
            //else if()
            //{}
            //else{}
            Console.WriteLine("只能获取当次课的公开课视频代码");
        }

        public override void GetVideoVisitor(IVisitor visitor)
        {
            visitor.GetVideoFree(this);//this 是当前的实例
        }
        

        //再建立多个方法  每个方法对应一种方式
        //再建立一堆的子类  分别去完成

    }
}
