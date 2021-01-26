using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class JNInterpreter : BaseInterpreter
    {
        private static Dictionary<char, string> _Dictionary = new Dictionary<char, string>();
        static JNInterpreter()
        {
            _Dictionary.Add('j', "a");
            _Dictionary.Add('k', "b");
            _Dictionary.Add('l', "c");
            _Dictionary.Add('m', "d");
            _Dictionary.Add('n', "e");
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
