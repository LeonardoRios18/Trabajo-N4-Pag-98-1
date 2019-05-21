using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Trabajo_N4_Pag_98_2
{
    class CApGrados0
    {

        public static void Main(string[] args)
        {
            CApGrados2 grados = new CApGrados2();
            // ...
            while (gradosCent <= limSuperior)
            {
                //Se obtienen los grados F equivalentes a G
                gradosFahr = grados.ObtenerFahrenheit(gradosCent);

            }
        }
    }



    class CApGrados2
{ 
        //Definicion de Constantes
        const int limInferior = -15;
        const int limSuperior = 150;
        const int incremento = 8;
        const int gradosC = 0;

        public static float ObtenerFahrenheit(float gradocC)
        {        //Retornacion de grados fahrenheit equivalentes a grados C
            return 9F / 5F * gradosC + 32;
            
        }
    public static void Main(string[] args)
      {
        //Declaracion de las variables 
        int gradosCent = limInferior;
        float gradosFahr = 0;

        while (gradosCent <= limSuperior) // Mientras se hace...
        {
            //Grados F a Grados C
            gradosFahr = ObtenerFahrenheit(gradosCent);
            //Escribe la siguiente linea en tabla
            System.Console.WriteLine("{0, 8:d} C {1, 8:f2} F", gradosCent, gradosFahr);
            //Valor Siguiente
            gradosCent += incremento;

                Console.WriteLine();
                Console.ReadLine();
        }
      }
    }
}