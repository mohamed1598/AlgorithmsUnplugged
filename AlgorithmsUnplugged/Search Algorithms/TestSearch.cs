using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Search_Algorithms
{
    public static class TestSearch
    {
        private readonly static ISearch sequential = new SequentialSearch();
        private readonly static ISearch binary = new BinarySearch();
        private readonly static ISearch recursiveBinary = new RecursiveBinarySearch();
        private readonly static int[] numbers = Enumerable.Range(250, 750).ToArray();

        public static void Test()
        {
            Console.WriteLine("sequential search");
            TestCases(sequential);
            Console.WriteLine("binary search");
            TestCases(binary);
            Console.WriteLine("recursive binary search");
            TestCases(recursiveBinary);
        }
        private static void TestCases(ISearch algorithm)
        {
            Case1(algorithm);
            Case2(algorithm);
            Case3(algorithm);
            Case4(algorithm);
            Case5(algorithm);
        }
        private static void Case1(ISearch algorithm)
        {
            int result = algorithm.Search(numbers, 100);
            if (result == -1)
                Console.WriteLine("    Test 1: works");
            else
                Console.WriteLine("    Test 1: fails");
        }
        private static void Case2(ISearch algorithm)
        {
            int result = algorithm.Search(numbers, 300);
            if (result != -1)
                Console.WriteLine("    Test 2: works");
            else
                Console.WriteLine("    Test 2: fails");
        }
        private static void Case3(ISearch algorithm)
        {
            int result = algorithm.Search(numbers, 250);
            if (result != -1)
                Console.WriteLine("    Test 3: works");
            else
                Console.WriteLine("    Test 3: fails");
        }
        private static void Case4(ISearch algorithm)
        {
            int result = algorithm.Search(numbers, 750);
            if (result != -1)
                Console.WriteLine("    Test 4: works");
            else
                Console.WriteLine("    Test 4: fails");
        }
        private static void Case5(ISearch algorithm)
        {
            int result = algorithm.Search(numbers, 1000);
            if (result == -1)
                Console.WriteLine("    Test 5: works");
            else
                Console.WriteLine("    Test 5: fails");
        }
    }
}
