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
    public class VisitorTemp : IVisitor
    {
        public void GetVideoFree(StudentFree studentFree)
        {
            Console.WriteLine("进群获取当次课的视频代码");
        }

        public void GetVideoVip(StudentVip studentVip)
        {
            Console.WriteLine("继续免费获取任何视频课件代码");
        }
    }
}
