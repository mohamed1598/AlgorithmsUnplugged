using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Sort_Algorithms
{
    public class QuickSort : ISort
    {
        public List<T> Sort<T>(List<T> list) where T : IComparable<T>
        {
            List<T> left = new();
                List<T> right = new();
            if (list.Count > 1)
            {
                T pivot = list[0];
                for(int i =1;i<list.Count;i++)
                {
                    if (list[i].CompareTo(pivot) > 0) right.Add(list[i]);
                    if(list[i].CompareTo(pivot) <= 0) left.Add(list[i]);
                }
                left =Sort(left);
                right = Sort(right);
                left.Add(pivot);
                left.AddRange(right);
            }
            else
            {
                return list;
            }
            return left;
        }
    }
}
