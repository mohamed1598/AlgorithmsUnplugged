using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsUnplugged.Finding_Primes
{
    public class SieveOfEratosthenes
    {
        public static List<int> GetPrimesTable(int limit = 1000)
        {
            List<int> primes = new();
            for(int i = 2; i< limit; i++) {
                bool isPrime = true;
                for(int j =0;j<primes.Count && primes[j] * primes[j] < i;j++)
                {
                    if(i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                    primes.Add(i);
            }
            
            return primes;
        }
        public static void PrintPrimesTable()
        {
            var limit = 10000000;
            var primes = GetPrimesTable(limit);
            foreach (var prime in primes)
            {
                Console.Write(prime + " ");
            }
        }
    }
}
