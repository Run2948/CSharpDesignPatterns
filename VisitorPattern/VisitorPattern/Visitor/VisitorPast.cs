using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Visitor
{
    /// <summary>
    /// 访问者：完成获取视频的行为
    /// </summary>
    public class VisitorPast : IVisitor
    {
        public void GetVideoFree(StudentFree studentFree)
        {
            Console.WriteLine("没有视频只有代码");
        }

        public void GetVideoVip(StudentVip studentVip)
        {
            Console.WriteLine("获取公开课代码合集");
        }
    }
}
