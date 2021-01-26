using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.User
{
    public interface IUserSystem
    {
        bool CheckUser(int id);
    }
}
