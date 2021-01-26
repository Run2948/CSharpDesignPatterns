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
    public class VisitorCurrent : IVisitor
    {
        public void GetVideoFree(StudentFree studentFree)
        {
            Console.WriteLine("只能获取当次课的公开课视频代码");
        }

        public void GetVideoVip(StudentVip studentVip)
        {
            Console.WriteLine("免费获取全套的公开课视频代码合集");
        }
    }
}
