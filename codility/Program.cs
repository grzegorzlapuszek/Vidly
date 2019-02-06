using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codility
{
    class Program
    {
        static int Solution(int[] N)
        {
            HashSet<int> hashset = new HashSet<int>();
            for (int i = 0; i < N.Length; i++)
            {
                hashset.Add(i); //fill hashset with numbers from 0 to N     -> 0 1 2 3 5
            }
            for (int i = 0; i < N.Length; i++)
            {
                hashset.Remove(N[i]);
            }

            return hashset.First();
        }
        static void Main(string[] args)
        {
            int[] A = { 3, 1, 0, 2, 5, 6, 7, 4, 9, 10, 11, 12};
            var result = Solution(A);
            Console.WriteLine(result);
        }
    }
}
