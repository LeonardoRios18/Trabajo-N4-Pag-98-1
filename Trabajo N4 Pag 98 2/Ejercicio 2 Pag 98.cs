﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_N4_Pag_98_2
{
    class CApGrados
    {
        // Definicion de constantes
        const int LimInferior = -50;
        const int LimSuperior = 120;
        const int Incremento = 5;


        public static float ObtenerFahrenheit(float gradosC)
        {
            // Retornar los grados fahrenheit equivalentes a grados C 
            return 9 / 5 * gradosC + 32;

            // Cambian los valores de grados en fahrenheit

        }
        public static void Main(string[] args)
        {
            // Declaracion de variables
            int gradosCent = LimInferior;
            float gradosFahr = 0;

            while (gradosCent <= LimSuperior) //  mientras ... hacer:
            {
                // Obtener los grados fahrenheit equivalentes a gradosCent
                gradosFahr = ObtenerFahrenheit(gradosCent);
                // Escribir la siguiente Linea de la tabla 
                System.Console.WriteLine("{0, 8:d} C {1, 8:f2} F", gradosCent, gradosFahr);
                // Siguiente valos
                gradosCent += Incremento;


                Console.WriteLine();
                Console.ReadLine();
            }
        }
    }
}
