using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Factoral
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter a number");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(GetFactorial(n));
                Console.WriteLine("Would you like me to continue? (Yes/No)");
                if (Console.ReadLine().ToLower() != "yes")
                    break;
            }
        }

        public static long GetFactorial(int n)
        {
            long acc = n;
            for (int i = 1; i <= n; i++)
            {
                acc *= i;
            }
            return acc;
        }
    }
}
