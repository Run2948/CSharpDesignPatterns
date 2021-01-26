using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    public class AIInterpreter : BaseInterpreter
    {
        private static Dictionary<char, string> _Dictionary = new Dictionary<char, string>();
        static AIInterpreter()
        {
            _Dictionary.Add('a', "1");
            _Dictionary.Add('b', "2");
            _Dictionary.Add('c', "3");
            _Dictionary.Add('d', "4");
            _Dictionary.Add('e', "5");
            _Dictionary.Add('f', "6");
            _Dictionary.Add('g', "7");
            _Dictionary.Add('h', "8");
            _Dictionary.Add('i', "9");
        }

        public override void Conversion(Context context)
        {
            string text = context.Get();
            if (string.IsNullOrEmpty(text))
                return;
            List<string> numberList = new List<string>();
            foreach (var item in text.ToLower().ToArray())
            {
                if (_Dictionary.ContainsKey(item))
                {
                    numberList.Add(_Dictionary[item]);
                }
                else
                {
                    numberList.Add(item.ToString());
                }
            }
            context.Set(string.Concat(numberList));
        }
    }
}
