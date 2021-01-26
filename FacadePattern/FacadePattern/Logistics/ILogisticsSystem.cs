using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.Logistics
{
    public interface ILogisticsSystem
    {
        bool CheckLogistics(int productId, int cityId);
        void NewLogistics(int productId, int cityId);
    }
}
