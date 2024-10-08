using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace calculadora
{
    internal class menu: Calculos
    {
        //public string menus { get; set; }
        public string? title { get; set; }

       

        public void RetornaTitulos(string title)
        {
            int tamanho = title.Length;
            string asteriscos = string.Empty.PadLeft(tamanho, '*');
            Console.Clear();
            Console.WriteLine(asteriscos);
            Console.WriteLine(title);
            Console.WriteLine(asteriscos);



        }



        public void RetornaMenu()
        {
        voltar:
            Console.Clear();

            Console.WriteLine("\nDigite 1 para Somar");
            Console.WriteLine("Digite 2 para Subtrair");
            Console.WriteLine("Digite 3 para Multiplicar");
            Console.WriteLine("Digite 4 para Dividir");
            Console.WriteLine("Digite 0 para sair");
            Console.Write("\nDigite a sua opção: ");
            var opcaoEscolhida = Console.ReadLine()!;
            bool ok = ValidaEntradaMenu(opcaoEscolhida);
            
            if (!ok)
            {
                opcaoEscolhida = "99";
            }
            int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);           
                switch (opcaoEscolhidaNumerica)
                {

                    case 1:
                    Console.Write("\nPor favor, digite o primeiro número: ");
                    Numero1 = EntradaNumero();
                    Console.Write("\nPor favor, digite o segundo número: ");
                    Numero2 = EntradaNumero();
                    Exibir(opcaoEscolhidaNumerica);
                    
                    
                    
                    break;
                    case 2:
                    Console.Write("\nPor favor, digite o primeiro número: ");
                    Numero1 = EntradaNumero();
                    Console.Write("\nPor favor, digite o segundo número: ");
                    Numero2 = EntradaNumero();
                    Exibir(opcaoEscolhidaNumerica);

                    break;
                    case 3:
                    Console.Write("\nPor favor, digite o primeiro número: ");
                    Numero1 = EntradaNumero();
                    Console.Write("\nPor favor, digite o segundo número: ");
                    Numero2 = EntradaNumero();
                    Exibir(opcaoEscolhidaNumerica);

                    break;
                    case 4:
                    Console.Write("\nPor favor, digite o primeiro número: ");
                    Numero1 = EntradaNumero();
                    Console.Write("\nPor favor, digite o segundo número: ");
                    Numero2 = EntradaNumero();
                    Exibir(opcaoEscolhidaNumerica);

                    break;
                    case 0:
                        Console.WriteLine("Tchau tchau :)");
                        break;
                    default:
                        Console.WriteLine("\n Opção inválida, tente novamente");
                        Console.ReadKey();
                    goto voltar;
                    
                }

        }


    }
}
