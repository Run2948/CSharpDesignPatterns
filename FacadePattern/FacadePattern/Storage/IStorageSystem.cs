using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Storage
{
    public interface IStorageSystem
    {
        bool CheckStorage(int productId);
    }
}
