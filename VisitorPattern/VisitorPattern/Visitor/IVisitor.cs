using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Visitor
{
    public interface IVisitor
    {
        void GetVideoFree(StudentFree studentFree);
        void GetVideoVip(StudentVip studentVip);

        //void GetVideoVVip(StudentVVip studentVVip);
    }
}
