using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class NewMenu


    {
        private Dictionary<int, ICalcular> _operacoes;

        public NewMenu()
        {
            _operacoes = new Dictionary<int, ICalcular>
            {
                { 1, new Soma() },
                { 2, new Subtracao() },
                { 3, new Multiplicacao() },
                { 4, new Divisao() },
                
            };
        }

        public void ExibirMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Calculadora");
                Console.WriteLine("Digite 1 para Somar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para Listar Operações Realizadas");
                Console.WriteLine("Digite 0 para sair");
                Console.Write("Digite a sua opção: ");
                var opcao = Console.ReadLine();

                if (opcao == "0") break;

                if (int.TryParse(opcao, out int opcaoEscolhida) && _operacoes.ContainsKey(opcaoEscolhida))
                {
                    Console.Write("Digite o primeiro número: ");
                    double num1 = double.Parse(Console.ReadLine()!);

                    Console.Write("Digite o segundo número: ");
                    double num2 = double.Parse(Console.ReadLine()!);

                    var op = _operacoes[opcaoEscolhida];
                    var resultado = op.Calcular(num1, num2);
                    op.Gravar(num1, num2, resultado);
                    // var resultado = _operacoes[opcaoEscolhida].Calcular(num1, num2);
                    op.GetExpressao();
                }
                else if (int.TryParse(opcao, out int result) && result == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }

                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();
            }
            Console.WriteLine("Tchau tchau :)");
        }


    }
}
