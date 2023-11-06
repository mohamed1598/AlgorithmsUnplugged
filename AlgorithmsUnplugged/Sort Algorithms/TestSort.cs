using AlgorithmsUnplugged.Search_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Sort_Algorithms
{
    public class TestSort
    {
        private static readonly ISort insertion = new InsertionSort();
        private static readonly ISort Merge = new MergeSort();
        private static readonly ISort Quick = new QuickSort();
        private static readonly ISort Bubble = new BubbleSort();
        private static List<int> numbers ; 
        private static List<string> texts ;
        private static List<double> doubles ;
        public static void Test() {
            Console.WriteLine("Insertion Sort :");
            TestCases(insertion);
            Console.WriteLine("Merge Sort :");
            TestCases(Merge);
            Console.WriteLine("Quick Sort :");
            TestCases(Quick);
            Console.WriteLine("Bubble Sort :");
            TestCases(Bubble);
        }
        private static void TestCases(ISort algorithm)
        {
            Case1(algorithm);
        }

        private static void SetDefault()
        {
            numbers = new() { 1, 2, 4, 10, 3, 18, 15, 7, 2, 8 };
            texts = new() { "a", "mohamed", "Mohamed", "b", "zz", "z" };
            doubles = new() { 1.2, 20, 30.5, 0.5, 0.3, 1.8 };
        }

        private static void Case1(ISort algorithm)
        {
            SetDefault();
            List<int> result = algorithm.Sort(numbers);
            SetDefault();
            List<string> txtResult = algorithm.Sort(texts);
            SetDefault();
            List<double> doubleResult = algorithm.Sort(doubles);
            PrintResult(txtResult);
            PrintResult(result);
            PrintResult(doubleResult);
        }
        public static void PrintResult<T>(List<T> result){
            Console.Write("     [");
            foreach (T i in result)
            {
                Console.Write($"{i} , ");
            }
            Console.WriteLine("]");
        }
    }
}
