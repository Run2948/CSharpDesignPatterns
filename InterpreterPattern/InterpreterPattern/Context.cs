using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterPattern
{
    /// <summary>
    /// 上下文
    /// </summary>
    public class Context
    {
        private string _Word = null;
        public Context(string word)
        {
            this._Word = word;
        }

        public void Set(string newWord)
        {
            this._Word = newWord;
        }

        public string Get()
        {
            return this._Word;
        }
    }
}
