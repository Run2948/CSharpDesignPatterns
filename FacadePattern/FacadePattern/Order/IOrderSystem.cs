using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Order
{
    public interface IOrderSystem
    {
        bool CheckOrder(int userId, int productId);
        void NewOrder(int userId, int productId);
    }
}
