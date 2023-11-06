using AlgorithmsUnplugged.Long_Multipliction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Greatest_Common_Divider
{
    public class TestGreatestCommonDivider
    {
        public static void Test()
        {
            Console.WriteLine("Euclid Algorithm");
            TestCases();
        }
        private static void TestCases()
        {
            Case1();
            Case2();
            Case3();
            Case4();
        }
        private static void Case1()
        {
            BigInteger result = Euclid.GetGreatestCommonDivider(3, 3);
            if (result == 3)
                Console.WriteLine("    Test 1: works");
            else
                Console.WriteLine("    Test 1: fails");
        }
        private static void Case2()
        {
            BigInteger result = Euclid.GetGreatestCommonDivider(1001, 2);
            if (result == 1)
                Console.WriteLine("    Test 2: works");
            else
                Console.WriteLine("    Test 2: fails");
        }
        private static void Case3()
        {
            BigInteger result = Euclid.GetGreatestCommonDivider(1324, 145);
            if (result == 1)
                Console.WriteLine("    Test 3: works");
            else
                Console.WriteLine("    Test 3: fails");
        }
        private static void Case4()
        {
            BigInteger result = Euclid.GetGreatestCommonDivider(128, 7);
            if (result == 1)
                Console.WriteLine("    Test 4: works");
            else
                Console.WriteLine("    Test 4: fails");
        }
    }
}
