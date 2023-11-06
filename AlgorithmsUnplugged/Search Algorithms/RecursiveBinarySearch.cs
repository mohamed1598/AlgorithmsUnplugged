using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Search_Algorithms
{
    public class RecursiveBinarySearch : ISearch
    {
        public int Search<T>(IEnumerable<T> list, T key) where T : IComparable<T>
        {
            int left = 0;
            int right = list.Count() - 1;
            if (left <= right)
            {
                var middle = (left + right) / 2;
                switch (list.ElementAt(middle).CompareTo(key))
                {
                    case 0:
                        return middle;
                    case < 0:
                        return Search(list.Skip(middle).Take(right-middle+1 < list.Count()?right - middle+1: right - middle), key);
                    case > 0:
                        return Search(list.Skip(0).Take(middle), key);
                }
            }
            return -1;
        }

    }
}
