using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Text_Search_Algorithms
{
    public class NaiveSearch : ITextSearch
    {
        public int Search(string text, string key)
        {
            int j = key.Length - 1;
            int i = j;
            while(i < text.Length)
            {
                if (key[j] == text[i])
                {
                    j--;
                    i --;
                }
                else
                {
                    i += key.Length - j;
                    j = key.Length - 1;
                }
                if(j < 0)
                {
                    return ++i;
                }
            }
            return -1;
        }
    }
}
