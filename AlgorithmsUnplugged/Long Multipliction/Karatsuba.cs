using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Long_Multipliction
{
    public class Karatsuba
    {
        public static BigInteger Multiply(BigInteger a, BigInteger b)
        {
            if(a < 10 || b < 10)
            {
                return a * b;
            }

            // k length of bigger integer divided by 2
            int k  = Math.Max(a.ToString().Length,b.ToString().Length) / 2;

            BigInteger aLeftHalf, arightHalf ;
            (aLeftHalf,arightHalf) = SplitBigIntegerTo2Halves(a, k);
            BigInteger bLeftHalf, brightHalf;
            (bLeftHalf, brightHalf) = SplitBigIntegerTo2Halves(b, k);

            BigInteger leftProduct = Multiply(aLeftHalf, bLeftHalf);
            BigInteger rightProduct = Multiply(arightHalf, brightHalf);
            BigInteger plusResult = Multiply(aLeftHalf + arightHalf, bLeftHalf + brightHalf) - leftProduct - rightProduct;

            return (leftProduct * BigInteger.Pow(10, 2 * k)) + (plusResult * BigInteger.Pow(10, k)) + rightProduct;
        }
        private static (BigInteger,BigInteger) SplitBigIntegerTo2Halves(BigInteger a,int length)
        {
            BigInteger leftHalf = a / BigInteger.Pow(10,length);
            BigInteger rightHalf = a % BigInteger.Pow(10,length);
            return (leftHalf, rightHalf);
        }
    }
}
