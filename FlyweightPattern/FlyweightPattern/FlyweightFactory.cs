using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    /// <summary>
    /// ThreadPool ConnPool
    /// </summary>
    public class FlyweightFactory
    {
        //private static BaseWord e1 = new E();
        //private static BaseWord l = new L();
        //private static BaseWord v = new V();
        //private static BaseWord n = new N();

        private static Dictionary<WordType, BaseWord> _BaseWordDictionary = new Dictionary<WordType, BaseWord>();
        private static object GetWord_Lock = new object();
        

        public static BaseWord GetWord(WordType wordType)
        {
            BaseWord baseWord = null;
            if (_BaseWordDictionary.ContainsKey(wordType))//双if+lock
            {
                baseWord = _BaseWordDictionary[wordType];
            }
            else
            {
                lock (GetWord_Lock)
                {
                    if (_BaseWordDictionary.ContainsKey(wordType))
                    {
                        baseWord = _BaseWordDictionary[wordType];
                    }
                    else
                    {
                        switch (wordType)
                        {
                            case WordType.E:
                                baseWord = new E();
                                break;
                            case WordType.L:
                                baseWord = new L();
                                break;
                            case WordType.V:
                                baseWord = new V();
                                break;
                            case WordType.N:
                                baseWord = new N();
                                break;
                            default:
                                throw new Exception("wrong wordType");
                        }
                        _BaseWordDictionary[wordType] = baseWord;
                    }
                }
            }
            return baseWord;
        }

    }

    public enum WordType
    {
        E,
        L,
        V,
        N
    }
}
