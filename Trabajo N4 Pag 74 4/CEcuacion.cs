using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_N4_Pag_74_4
{
    class CEcuacion
    {
        //El termino de mayor grado tiene exponenete 3 fijo
        private double c3, c2, c1, c0; // coeficientes

        public CEcuacion(double a, double b, double c, double d)
        {
            c3 = a; c2 = b; c1 = c; c0 = d;
        }

        public double ValorPara(double x)
        {
            double resultado;
            resultado = c3 * x * x * x + c2 * x * x + c1 * x + c0;
            return resultado;// devolver el valor calculado
        }
    }
}









