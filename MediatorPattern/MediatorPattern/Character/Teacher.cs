using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Character
{
    public class Teacher : BaseCharacter
    {

        public override void SendMessage(string message, BaseCharacter characterTo)
        {
            Console.WriteLine("{0}老师to {1}:{2}", base.Name, characterTo.Name, message);
            
            characterTo.GetMessage(message, this);

        }

        public override void GetMessage(string message, BaseCharacter characterFrom)
        {
            Console.WriteLine("{0}老师get{1}:{2}", base.Name, characterFrom.Name, message);
        }
    }
}
