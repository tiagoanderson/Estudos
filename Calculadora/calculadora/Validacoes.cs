using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Validacoes
    {

        public double EntradaNumero()
        {
            while (true)
            {
                // Entrada do primeiro número

                var entrada = Console.ReadLine();
                if (!ValidaEntradaNumero(entrada!))
                {
                    //Console.Clear();
                    Console.Write("\n Valor Invalido, por favor tente novamente: ");
                    continue; // Continua pedindo entradas até serem válidas
                }
                else
                {
                    Console.Clear();
                    double Numero = double.Parse(entrada!);
                    return Numero;
                }


            }

        }



        public bool ValidaEntradaMenu(string numero)
        {
            bool ok = Regex.IsMatch(numero, "^[0-4]+$");
            return ok;
        }


        public bool ValidaEntradaNumero(string numero)
        {
            string pattern = @"^[0-9]+(\,[0-9]+)?$";
            bool ok = Regex.IsMatch(numero, pattern);
            return ok;
        }




    }
}
