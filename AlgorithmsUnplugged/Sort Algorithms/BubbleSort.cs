using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Sort_Algorithms
{
    public class BubbleSort : ISort
    {
        public List<T> Sort<T>(List<T> list) where T : IComparable<T>
        {
            for (int i = 0; i <list.Count - 1; i++)
                for (int j = 0; j < list.Count - 1; j++)
                    if (list[j+1].CompareTo(list[j]) < 0)
                    {
                        (list[j + 1], list[j]) = (list[j], list[j + 1]);
                    }
            return list;
        }
    }
}
