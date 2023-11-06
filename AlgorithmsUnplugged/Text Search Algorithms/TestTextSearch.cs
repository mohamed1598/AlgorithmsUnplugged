using AlgorithmsUnplugged.Search_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Text_Search_Algorithms
{
    public static class TestTextSearch
    {
        private readonly static ITextSearch naive = new NaiveSearch();
        private readonly static ITextSearch boyerMooreHorspool = new BoyerMooreHorspoolAlgorithm();
        public static void Test()
        {
            Console.WriteLine("naive search");
            TestCases(naive);
            Console.WriteLine("BoyerMooreHorspool search");
            TestCases(boyerMooreHorspool);
        }
        private static void TestCases(ITextSearch algorithm)
        {
            Case1(algorithm);
            Case2(algorithm);
            Case3(algorithm);
            Case4(algorithm);
        }
        private static void Case1(ITextSearch algorithm)
        {
            string text = "Haystack with a needle";
            string key = "needle";
            int result = algorithm.Search(text, key);
            if (result == 16)
                Console.WriteLine("    Test 1: works");
            else
                Console.WriteLine("    Test 1: fails");
        }
        private static void Case2(ITextSearch algorithm)
        {
            string text = "Haystack with a needle";
            string key = "needlex";
            int result = algorithm.Search(text, key);
            if (result == -1)
                Console.WriteLine("    Test 2: works");
            else
                Console.WriteLine("    Test 2: fails");
        }
        private static void Case3(ITextSearch algorithm)
        {
            string text = "Test 1";
            string key = "Test";
            int result = algorithm.Search(text, key);
            if (result == 0)
                Console.WriteLine("    Test 3: works");
            else
                Console.WriteLine("    Test 3: fails");
        }
        private static void Case4(ITextSearch algorithm)
        {
            string text = "Test 1";
            string key = "ss";
            int result = algorithm.Search(text, key);
            if (result == -1)
                Console.WriteLine("    Test 4: works");
            else
                Console.WriteLine("    Test 4: fails");
        }
    }
}
