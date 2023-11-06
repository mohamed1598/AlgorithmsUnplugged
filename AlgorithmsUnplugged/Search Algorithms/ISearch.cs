using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Search_Algorithms
{
    public interface ISearch
    {
        int Search<T>(IEnumerable<T> list, T key) where T : IComparable<T>;
    }
}
