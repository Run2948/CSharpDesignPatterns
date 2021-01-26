using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    public class Manager : BaseAuditor
    {

        public override void Audit(ApplyContext context)
        {
            if (context.Hour <= 24)
            {
                context.AuditResult = true;
                context.AuditRemark = "Enjoy your vacation";
            }
            else
            {
                if (base._NextAudtitor == null)
                {
                    context.AuditResult = false;
                    context.AuditRemark = "审批不通过";
                }
                else
                {
                    base._NextAudtitor.Audit(context);
                }
            }
        }
    }
}
