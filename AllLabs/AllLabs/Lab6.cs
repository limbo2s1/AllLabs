using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllLabs
{
    internal class Lab6
    {
        static int Fibonachi(int n)
        {
            if (n == 0 || n == 1) return n;
            {
                return Fibonachi(n - 1) + Fibonachi(n - 2);
            }
        }
        static void Main(string[] args)
        {
            int fib = Fibonachi(32);
            Console.WriteLine("Число = " + fib);
            Console.ReadLine();
        }
    }
}
