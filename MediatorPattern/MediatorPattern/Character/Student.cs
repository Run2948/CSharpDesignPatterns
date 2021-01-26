using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Character
{
    public class Student : BaseCharacter
    {

        public override void SendMessage(string message, BaseCharacter characterTo)
        {
            Console.WriteLine("{0}学员to {1}:{2}", this.Name, characterTo.Name, message);
            characterTo.GetMessage(message, this);
        }

        public override void GetMessage(string message, BaseCharacter characterFrom)
        {
            Console.WriteLine("{0}学员get{1}:{2}", base.Name, characterFrom.Name, message);
        }
    }
}
