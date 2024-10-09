using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal interface ICalcular
    {
        public double Calcular(double Numero1, double Numero2);
        public void Gravar(double Numero1, double Numero2, double Resultado);
        public void GetExpressao();
    }



}

