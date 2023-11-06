using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Sort_Algorithms
{
    public class MergeSort : ISort
    {
        public  List<T> Sort<T>(List<T> list)where T : IComparable<T>
        {
            List<T> result;
            if(list.Count > 1)
            {
                int medium = list.Count / 2;
                var resultL = Sort(list.Skip(0).Take(medium).ToList());
                var resultR =Sort(list.Skip(medium).Take(list.Count - medium).ToList());
                result = Merge(resultL, resultR);
            }
            else
            {
                return list;
            }
            return result;
        }
        private static List<T> Merge<T>(List<T> left,List<T> right) where T : IComparable<T>
        {
            int i=0, j = 0,leftLength = left.Count,rightLength= right.Count;
            List<T> result = new();
            for(int k=0; i < leftLength || j <rightLength;k++)
            {
                if(i >= leftLength) {
                    result.Add(right[j++]);
                    continue;
                }
                if(j>= rightLength)
                {
                    result.Add(left[i++]);
                    continue;
                }
                result.Add(left[i].CompareTo(right[j])<0 ? left[i++] : right[j++]);
            }
            return result;
        }
    }
}
