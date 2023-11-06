using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Greatest_Common_Divider
{
    public class Euclid
    {
        public static int GetGreatestCommonDivider(int a ,int b)
        {
            if (a < b) (a, b) = (b, a);
            if (a % b == 0) return b;
            return GetGreatestCommonDivider(a%b,b);
        }
    }
}
