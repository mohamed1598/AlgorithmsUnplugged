using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Sort_Algorithms
{
    public class SelectionSort : ISort
    {
        public List<T> Sort<T>(List<T> list) where T : IComparable<T>
        {
            for(int i =0; i < list.Count-1; i++)
            {
                int min = i;
                for(int j =i+1;j< list.Count; j++)
                {
                    if (list[j].CompareTo(list[min]) < 0)
                        min = j;
                }
                (list[min], list[i]) = (list[i], list[min]);
            }
            return list;
        }
    }
}
