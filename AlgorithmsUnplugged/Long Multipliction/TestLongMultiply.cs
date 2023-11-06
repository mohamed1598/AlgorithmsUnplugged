using AlgorithmsUnplugged.Search_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Long_Multipliction
{
    public class TestLongMultiply
    {
        public static void Test()
        {
            Console.WriteLine("Karatsuba Multiply");
            TestCases();
        }
        private static void TestCases()
        {
            Case1();
            Case2();
            Case3();
        }
        private static void Case1()
        {
            BigInteger result = Karatsuba.Multiply(1234567890123456789, 9876543210987654321);
            BigInteger answer = BigInteger.Parse("12193263113702179522374638011112635269");
            if (result == answer)
                Console.WriteLine("    Test 1: works");
            else
                Console.WriteLine("    Test 1: fails");
        }
        private static void Case2()
        {
            BigInteger result = Karatsuba.Multiply(BigInteger.Parse("654154154151454545415415454"), BigInteger.Parse("63516561563156316545145146514654"));
            BigInteger answer = BigInteger.Parse("41549622603955309777243716069997997007620439937711509062916");
            if (result == answer)
                Console.WriteLine("    Test 1: works");
            else
                Console.WriteLine("    Test 1: fails");
        }
        private static void Case3()
        {
            BigInteger result = Karatsuba.Multiply(BigInteger.Parse("654154154151454545415415454"), BigInteger.Parse("63516561563156316545145146514654"));
            BigInteger answer = BigInteger.Parse("51549622603955309777243716069997997007620439937711509062916");
            if (result != answer)
                Console.WriteLine("    Test 1: works");
            else
                Console.WriteLine("    Test 1: fails");
        }
    }
}
