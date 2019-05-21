using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_N4_Pag_74_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el valor de A:");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de B:");
            double a2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de C:");
            double a3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de D:");
            double a4 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de X:");
            double x = double.Parse(Console.ReadLine());

            CEcuacion cls = new CEcuacion(a1, a2, a3, a4);
            Console.WriteLine(cls.ValorPara(x));

            Console.ReadLine();
        }
    }
}
