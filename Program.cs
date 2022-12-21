using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, sum;
            int start, end;

            Console.Write("Start :  ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("End :  ");
            end = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers within the range are  ");
            for (n = start; n <= end; n++)
            {
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum  += i;
                    i++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
            }
            Console.Write("\n");
        }
    }
}
