using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Search_Algorithms
{
    public class BinarySearch : ISearch
    {
        public int Search<T>(IEnumerable<T> list, T key) where T : IComparable<T>
        {
            int left = 0;
            int right = list.Count() - 1;
            while (left <= right)
            {
                var middle = (left + right) / 2;
                switch (list.ElementAt(middle).CompareTo(key))
                {
                    case 0:
                        return middle;
                    case < 0:
                        left = middle +1;
                        break;
                    case > 0:
                        right = middle - 1;
                        break;
                }
            }
            return -1;
        }
    }
}
