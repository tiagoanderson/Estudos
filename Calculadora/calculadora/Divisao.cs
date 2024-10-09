using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Divisao : ICalcular
    {
        private List<string> expressao = new List<string>();
        public double Calcular(double Numero1, double Numero2)
        {
            return Numero1 / Numero2;
        }

        public void Gravar(double Numero1, double Numero2, double Resultado)
        {
            string expresao = Numero1.ToString() + '/' + Numero2.ToString() + '=' + Resultado.ToString();
            expressao.Add(expresao);

        }

        public void GetExpressao()
        {
            foreach (var item in expressao)
            {
                Console.WriteLine(item);

            }
        }
    }
}
