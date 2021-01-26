using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    public class PM : BaseAuditor
    {



        public override void Audit(ApplyContext context)
        {

            context.AuditRemark += "PM开始处理";//不纯粹的责任链

            if (context.Hour <= 8)
            {
                context.AuditResult = true;
                context.AuditRemark = "Enjoy your vacation";
            }
            else
            {
                //Charge charge = new Charge()
                //{
                //    Name = "ObjectIsNotFound"
                //};
                //charge.Audit(context);
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
