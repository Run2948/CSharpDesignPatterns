using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsibilityChainPattern
{
    /// <summary>
    /// 1 责任链模式介绍和应用
    /// 2 .net框架中的责任链模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("欢迎来到.net高级班公开课之设计模式特训，今天是Eleven老师为大家带来的责任链模式");
                ApplyContext context = new ApplyContext()
                {
                    Id = 506,
                    Name = "yoyo",
                    Hour = 40,
                    Description = "我想参加软谋教育的线下聚会",
                    AuditResult = false,
                    AuditRemark = ""
                };


                BaseAuditor auditor = AuditorManager.GetAuditor();
                auditor.Audit(context);

                //PM pm = new PM()
                //{
                //    Name = "一点半"
                //};
                //Charge charge = new Charge()
                //{
                //    Name = "ObjectIsNotFound"
                //};
                //Manager manager = new Manager()
                //{
                //    Name = "Gain"
                //};

                //pm.SetNext(charge);
                //charge.SetNext(manager);


                //pm.Audit(context);

                if (context.AuditResult)
                {
                    Console.WriteLine("审批通过");
                }
                else
                {
                    Console.WriteLine("审批没通过");
                }



                //pm.Audit(context);

                //if (context.AuditResult)
                //{
                //    Console.WriteLine("审批通过");
                //}
                //else
                //{
                //    Console.WriteLine("审批没通过");
                //}

                ////找人逻辑都写在上端
                //pm.Audit(context);
                //if (context.AuditResult)
                //{
                //    Console.WriteLine("PM审批通过");
                //}
                //else
                //{
                //    charge.Audit(context);
                //    if (context.AuditResult)
                //    {
                //        Console.WriteLine("主管审批通过");
                //    }
                //    else
                //    {
                //        manager.Audit(context);
                //        if (context.AuditResult)
                //        {
                //            Console.WriteLine("经理审批通过");
                //        }
                //        else
                //        {

                //        }
                //    }
                //}

                ////审批逻辑都写在上端
                //if (context.Hour <= 8)
                //{
                //    Console.WriteLine("PM审批通过");
                //}
                //else if (context.Hour <= 16)
                //{
                //    Console.WriteLine("主管审批通过");
                //}
                //else
                //{
                //    Console.WriteLine("************");
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
