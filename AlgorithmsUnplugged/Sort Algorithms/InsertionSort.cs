using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Sort_Algorithms
{
    public class InsertionSort : ISort
    {
        public List<T> Sort<T>(List<T> list) where T : IComparable<T>
        {
            for(int i =1;i<list.Count;i++)
            {
                for(int j = i - 1; j >=0; j--)
                {
                    if (list[i].CompareTo(list[j]) < 0)
                    {
                        (list[i], list[j]) = (list[j], list[i]);
                        i-=2;
                        break;
                    }
                }
            }
            return list;
        }
    }
}
