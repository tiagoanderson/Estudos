using System.Diagnostics.CodeAnalysis;

namespace calculadora
{
    [ExcludeFromCodeCoverage]
    internal class NewMenu : DadosConcretos
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
            Func<string, bool> ehNumero = x => double.TryParse(x, out _);

            while (true)
            {


                Console.Clear();
                Console.WriteLine($" Calculadora");
                Console.WriteLine("Digite 1 para Somar");
                Console.WriteLine("Digite 2 para Subtrair");
                Console.WriteLine("Digite 3 para Multiplicar");
                Console.WriteLine("Digite 4 para Dividir");
                Console.WriteLine("Digite 5 para Listar Operações Realizadas");
                Console.WriteLine("Digite 0 para Sair");
                Console.Write('\n' + "Digite a sua opção: ");
                var opcao = Console.ReadLine();

                if (opcao == "0") break;

                if (int.TryParse(opcao, out int opcaoEscolhida))
                {
                    if (_operacoes.ContainsKey(opcaoEscolhida))
                    {
                        Console.Clear();
                        double num1, num2;
                        string input;

                        do
                        {
                            Console.Write("Digite o primeiro número: ");
                            input = Console.ReadLine();
                            if (!ehNumero(input))
                            {
                                Console.Clear();
                                Console.WriteLine("Entrada Inválida. Por favor, digite novamente.");


                            }
                        } while (!ehNumero(input) || !double.TryParse(input, out num1));

                        do
                        {
                            Console.Write("Digite o segundo número: ");

                            input = Console.ReadLine();
                            if (!ehNumero(input))
                            {
                                Console.Clear();
                                Console.WriteLine("Entrada Inválida. Por favor, digite novamente.");

                            }
                        } while (!ehNumero(input) || !double.TryParse(input, out num2));

                        var op = _operacoes[opcaoEscolhida];
                        var resultado = op.Calcular(num1, num2);
                        GravarDados(num1, num2, resultado, opcaoEscolhida);
                        GetOperacao();
                    }
                    else if (opcaoEscolhida == 5)
                    {
                        GetExpressao();
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida, tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine('\n' + "Entrada inválida. Por favor, digite um número inteiro.");
                }

                Console.WriteLine('\n');
                Console.WriteLine("Pressione uma tecla para continuar...");
                Console.ReadKey();

            }
            Console.WriteLine("Tchau tchau :)");
        }
    }
}
