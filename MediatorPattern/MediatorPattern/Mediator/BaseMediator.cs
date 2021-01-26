using MediatorPattern.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Mediator
{
    public class BaseMediator
    {
        public string Name { get; set; }
        private List<BaseCharacter> _BaseCharacterList = new List<BaseCharacter>();

        public void AddCharacter(BaseCharacter baseCharacter)
        {
            this._BaseCharacterList.Add(baseCharacter);
        }

        /// <summary>
        /// 群里面发消息的功能
        /// </summary>
        /// <param name="message"></param>
        /// <param name="characterFrom"></param>
        public void SendMessage(string message, BaseCharacter characterFrom)
        {
            Console.WriteLine("{0}Send:{1}", characterFrom.Name, message);
            foreach (var item in this._BaseCharacterList)
            {
                item.GetMessage(message, characterFrom);
            }

        }

    }
}
