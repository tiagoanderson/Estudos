using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Multiplicacao : ICalcular
    {

        public double Calcular(double Numero1, double Numero2)
        {
            return Numero1 * Numero2;
        }


    }
}
