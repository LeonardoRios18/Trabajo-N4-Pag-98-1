using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_N4_Pag_74_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, c = 2, k = 3;
            double b = -1.7, d = 3.5, x = 10.5;
            double res1 = 0.0, res2 = 0.0, res3 = 0.0;


            res1 = Math.Pow(x, 4);
            res2 = Math.Pow(x, 3);
            res3 = Math.Pow(x, 2);

            Console.WriteLine("Ecuacion     ax^4+bx^3-cx^2+dx+k");
            Console.WriteLine("\n");
            Console.Write($"{a} ({res1}) + {b} ({res2})+ {d} + {k}");
            Console.ReadLine();
        }
    }
}

