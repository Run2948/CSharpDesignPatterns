using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Storage
{
    public class StorageSystem : IStorageSystem
    {
        public bool CheckStorage(int productId)
        {
            return true;
        }
    }
}
