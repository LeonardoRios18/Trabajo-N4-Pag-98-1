using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_N4_Pag_124_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el radio");
            var radio = Console.ReadLine();
            var respuesta = double.TryParse(radio, out double va1);

            if (respuesta == (true))
            {
                va1 = double.Parse(radio);
                double po = Math.Pow(va1, 3);
                double res = 4 * Math.PI * po / 3;
                Console.WriteLine($"resultado: {res}");
                Console.ReadLine();


            }
            else
            {
                Console.WriteLine("ERROR RECUERDE QUE EL VALOR INGRESADO DEBE SER NUMERO");
                Console.ReadLine();

            }
        }
    }
}

