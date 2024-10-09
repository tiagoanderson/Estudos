namespace calculadora.Itens;
public class Calculator
{
    private readonly OperationHistory _operationHistory;

    public Calculator()
    {
        _operationHistory = new OperationHistory();
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("+++++++++++++++ Calculadora +++++++++++++++");
            Console.WriteLine("Selecione tipo de operação:");
            Console.WriteLine("1 - Soma\n2 - Subtração\n3 - Multiplicação\n4 - Divisão\nH - Histórico\n99 - SAIR");

            var option = Console.ReadLine();

            if (option == "99")
            {
                Console.WriteLine("Você escolheu Sair. O programa será encerrado.");
                break;
            }

            if (option == "H")
            {
                _operationHistory.ShowHistory();
                continue;
            }

            if (!int.TryParse(option, out int selectedOperation) || selectedOperation < 1 || selectedOperation > 4)
            {
                Console.WriteLine("Opção inválida, tente novamente.");
                continue;
            }

            Console.WriteLine("Digite o primeiro número:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            float n2 = float.Parse(Console.ReadLine());

            Operation operation = selectedOperation switch
            {
                1 => new Addition(),
                2 => new Subtraction(),
                3 => new Multiplication(),
                4 => new Division(),
                _ => throw new InvalidOperationException("Operação inválida")
            };

            float result = operation.Execute(n1, n2);
            Console.WriteLine($"Resultado: {result}");

            _operationHistory.AddEntry(n1, n2, operation, result);
        }
    }
}