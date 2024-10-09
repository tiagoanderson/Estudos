using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Textos
    {

        public void RetornaTitulos(string title)
        {
            int tamanho = title.Length;
            string asteriscos = string.Empty.PadLeft(tamanho, '*');
            Console.Clear();
            Console.WriteLine(asteriscos);
            Console.WriteLine(title);
            Console.WriteLine(asteriscos);

        }


        public void MsgEntrada(int cod)
        {
            switch (cod)
            {
                case 1:
                    Console.WriteLine("\nPor favor, digite o primeiro número: ");
                    break;
                case 2:
                    Console.WriteLine("\nPor favor, digite o Segundo número: ");
                    break;
            }


        }



        public void MsgTituloOperacoes(int cod)
        {
            switch (cod)
            {
                case 999:
                    RetornaTitulos("Calculadora TOP ");
                    break;
                case 1:
                    RetornaTitulos("Calculadora TOP - Operação SOMA");
                    break;
                case 2:
                    RetornaTitulos("Calculadora TOP - Operação SUBTRAÇÃO");
                    break;
                case 3:
                    RetornaTitulos("Calculadora TOP - Operação MULTIPLICAÇÃO");
                    break;
                case 4:
                    RetornaTitulos("Calculadora TOP - Operação DIVISÃO");
                    break;
            }


        }


        public void MsgErroNumero(int cod)
        {
            switch (cod)
            {
                case 1:

                    Console.Write("\n Valor Invalido, por favor tente novamente: ");
                    break;
              
            }

        }


    }




}
