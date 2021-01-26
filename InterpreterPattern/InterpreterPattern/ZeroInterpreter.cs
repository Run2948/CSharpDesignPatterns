using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 其他的都转成0
    /// </summary>
    public class ZeroInterpreter : BaseInterpreter
    {
        private static Dictionary<char, string> _Dictionary = new Dictionary<char, string>();
        static ZeroInterpreter()
        {
            _Dictionary.Add('1', "1");
            _Dictionary.Add('2', "2");
            _Dictionary.Add('3', "3");
            _Dictionary.Add('4', "4");
            _Dictionary.Add('5', "5");
            _Dictionary.Add('6', "6");
            _Dictionary.Add('7', "7");
            _Dictionary.Add('8', "8");
            _Dictionary.Add('9', "9");
        }

        public override void Conversion(Context context)
        {
            string text = context.Get();
            if (string.IsNullOrEmpty(text))
                return;
            List<string> numberList = new List<string>();
            foreach (var item in text.ToLower().ToArray())
            {
                if (!_Dictionary.ContainsKey(item))
                {
                    numberList.Add("0");
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
