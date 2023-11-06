using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Search_Algorithms
{
    public class SequentialSearch:ISearch
    {
        public  int Search<T>(IEnumerable<T> list,T key) where T : IComparable<T>
        {
            for(int matchedIndex = 0; matchedIndex < list.Count(); matchedIndex++)
            {
                if(list.ElementAt(matchedIndex).CompareTo(key) == 0)
                    return matchedIndex;
            }
            return -1;
        }
    }
}
