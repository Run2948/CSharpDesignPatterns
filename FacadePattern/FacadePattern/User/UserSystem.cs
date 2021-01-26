using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.User
{
    public class UserSystem : IUserSystem
    {

        public UserSystem(string name)
        { }

        public bool CheckUser(int id)
        {
            return id > 100;
        }
    }
}
