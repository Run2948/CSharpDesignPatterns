using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Character
{
    /// <summary>
    /// 定义一个人
    /// </summary>
    public abstract class BaseCharacter
    {
        public string Name { get; set; }

        public abstract void SendMessage(string message, BaseCharacter characterTo);

        public abstract void GetMessage(string message, BaseCharacter characterFrom);
    }
}
