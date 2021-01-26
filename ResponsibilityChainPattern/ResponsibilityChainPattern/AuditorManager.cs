using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    public class AuditorManager
    {
        private static BaseAuditor AuditorProcess = null;

        static AuditorManager()
        {
            PM pm = new PM()
            {
                Name = "一点半"
            };
            Charge charge = new Charge()
            {
                Name = "ObjectIsNotFound"
            };
            Manager manager = new Manager()
            {
                Name = "Gain"
            };

            CTO cto = new CTO()
            {
                Name = "十年"
            };

            //pm.SetNext(charge);
            //charge.SetNext(manager);
            //manager.SetNext(cto);
            pm.SetNext(manager);
            manager.SetNext(cto);

            AuditorProcess = pm;
        }

        public static BaseAuditor GetAuditor()
        {
            return AuditorProcess;
        }
    }
}
