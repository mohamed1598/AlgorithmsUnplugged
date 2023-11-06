using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Sort_Algorithms
{
    public interface ISort
    {
        List<T> Sort<T>(List<T> list) where T : IComparable<T>;
    }
}
