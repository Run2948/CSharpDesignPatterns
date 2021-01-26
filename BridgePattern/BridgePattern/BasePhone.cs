using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 抽象父类
    /// </summary>
    public abstract class BasePhone
    {
        public int Price { get; set; }
        /// <summary>
        /// 操作系统
        /// </summary>
        /// <returns></returns>
        public abstract string System();
        /// <summary>
        /// 系统版本
        /// </summary>
        /// <returns></returns>
        public abstract string Version();
        /// <summary>
        /// 打电话
        /// </summary>
        public abstract void Call();
        /// <summary>
        /// 发短信
        /// </summary>
        public abstract void Text();
    }
}
