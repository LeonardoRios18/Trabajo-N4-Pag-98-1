using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_N4_Pag_124_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Digite el año de nacimiento");
            var añonacimiento = Console.ReadLine();
            var respuesta = double.TryParse(añonacimiento, out double a);

            if (respuesta == (true))
            {
            }
            a = double.Parse(añonacimiento);
            double res = 2030 - a;
            Console.WriteLine($"Hola {nombre} en el 2030 tendras {res} años ");
            Console.ReadLine();

        }
    }
}
