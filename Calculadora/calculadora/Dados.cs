using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal abstract class Dados
    {
        private string simbolOperador = string.Empty;
        private string textOperador = string.Empty;
        private List<string> expressao = new List<string>();
        
        public void GravarDados(double Numero1, double Numero2, double Resultado, int operacao)
        {


            switch (operacao)
            {
                case 1:
                    simbolOperador = "+";
                    textOperador = "SOMA";
                    break;
                case 2:
                    simbolOperador = "-";
                    textOperador = "SUBTRAÇÃO";
                    break;
                case 3:
                    simbolOperador = "*";
                    textOperador = "MULTIPLICAÇÃO";
                    break;
                case 4:
                    simbolOperador = "/";
                    textOperador = "DIVISÃO";
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    return;
            }

            string ex = Numero1.ToString() + ' ' + simbolOperador + ' ' + Numero2.ToString() + " = " + Resultado.ToString();
            expressao.Add(ex);

        }

        public void GetExpressao()
        {
            Console.Clear();
            Console.WriteLine("********** Lista de Operações Realizadas ***********");

            if (expressao.Any())
            {
                foreach (var exp in expressao)
                {
                    Console.WriteLine(exp);
                }
            }
            else
            {
                Console.WriteLine('\n'+"Não existe operações realizadas");
            }
        }


        public void GetOperacao()
        {
            Console.Clear();
            Console.WriteLine($"***** Operação {this.textOperador} realizada *****");
            var op = expressao.Count - 1;

            Console.WriteLine(expressao[op]);





        }



    }
}
