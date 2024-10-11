using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Divisao : ICalcular
    {

        public double Calcular(double Numero1, double Numero2)
        {
            if (Numero2 == 0)
            {
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            }
            return Numero1 / Numero2;
        }



    }
}
