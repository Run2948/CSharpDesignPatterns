using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 一个代理
    /// </summary>
    public class ProxySubject : ISubject
    {
        private ISubject realSubject = null;// new RealSubject();

        private ISubject _RealSubject
        {
            get
            {
                if (this.realSubject == null)
                    realSubject = new RealSubject();
                return realSubject;
            }
        }


        public ProxySubject()
        {
        }


        /// <summary>
        /// 0 未初始化  1true  -1 false
        /// </summary>
        private static int _GetSomethingResult = 0;

        /// <summary>
        /// 
        /// </summary>
        public bool GetSomething()
        {
            try
            {
                Console.WriteLine("GetSomething start...");
                if (_GetSomethingResult == 0)
                {
                    bool bResult = this._RealSubject.GetSomething();
                    _GetSomethingResult = bResult ? 1 : -1;
                }
                Console.WriteLine("GetSomething end...");
                return _GetSomethingResult == 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void DoSomething()
        {
            Console.WriteLine("DoSomething start...");
            this._RealSubject.DoSomething();
            Console.WriteLine("DoSomething end...");
        }


        //public void GetDoSomething()
        //{
 
        //}
    }
}
