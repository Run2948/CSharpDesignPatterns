using StrategyPattern.Caculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 上下文环境  行为型设计模式的标志
    /// </summary>
    public class Context
    {
        private int _iInputLeft = 0;
        private int _iInputRight = 0;
        private BaseCaculation _baseCaculation = null;

        private string _CurrentOS = "Win10";

        public Context(int iInputLeft, int iInputRight, BaseCaculation baseCaculation)
        {
            this._iInputLeft = iInputLeft;
            this._iInputRight = iInputRight;
            this._baseCaculation = baseCaculation;
        }

        public int Caculation()
        {
            try
            {
                Console.WriteLine("当前的操作系统:{0}", this._CurrentOS);
                Console.WriteLine("prepare:iInputLeft={0} iInputRight={1}", _iInputLeft, _iInputRight);
                return this._baseCaculation.Cuculation(this._iInputLeft, this._iInputRight);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
