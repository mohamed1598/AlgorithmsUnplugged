using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Text_Search_Algorithms
{
    public class BoyerMooreHorspoolAlgorithm : ITextSearch
    {
        public int Search(string text, string key)
        {
            ComputeKeyTable("stacks");
            ComputeKeyTable("needle");
            ComputeKeyTable("with");
            Dictionary<char, int> tableD = ComputeKeyTable(key);
            int j = key.Length - 1;
            int i = j;
            while (i < text.Length)
            {
                if (key[j] == text[i])
                {   if (j == 0)
                    {
                        return i;
                    }
                    j--;
                    i--;
                }
                else
                {
                    if (tableD.TryGetValue(text[i],  out int value))
                    {
                        i += key.Length + value - j  - 1;
                    }
                    else
                    {
                        i += key.Length - j;
                    }
                    j = key.Length - 1;
                }
            }
            return -1;
        }
        private static Dictionary<char,int> ComputeKeyTable(string key)
        {
            Dictionary<char, int> tableD = new();
            for(int i = key.Length - 2; i >= 0; i--)
            {
                if (!tableD.TryGetValue(key[i], out _))
                {
                    tableD.Add(key[i], key.Length-i-1);
                }
            }
            if (!tableD.TryGetValue(key[^1], out _))
            {
                tableD.Add(key[^1], key.Length);
            }
            return tableD;
        }
    }
}
