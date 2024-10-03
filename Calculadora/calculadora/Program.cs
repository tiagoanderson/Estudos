using System;
using System.Text.RegularExpressions;

float n1 = 0;
float n2 = 0;
float resultado = 0;
float seletor = 99;



while (seletor != 99)
    Console.Write("+++++++++++++++Calculadora+++++++++++++++\n ");
    Console.WriteLine("Selecione tipo de operação:\n 1-Soma\n 2-Subtração\n 3-Multiplicação\n 4-Divisão \n 99 - SAIR");
voltaAqui:
var entrada = Console.ReadLine();
bool ok = Regex.IsMatch(entrada, "^[0-9]+$");
if (!ok)
{
    Console.WriteLine("O valor informado não é um numérico válido, tente novamente:");
    Task.Delay(2000).Wait();
    Console.Clear();
    Console.WriteLine("Selecione tipo de operação:\n 1-Soma\n 2-Subtração\n 3-Multiplicação\n 4-Divisão \n 99 - SAIR");
    goto voltaAqui;
}
else
{

    seletor = float.Parse(entrada);
    switch (seletor)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Você escolheu Soma: \n Digite um numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            n2 = float.Parse(Console.ReadLine());
            resultado = n1 + n2;
            Console.WriteLine($"A soma de {n1} + {n2} = {resultado}");
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Você escolheu Subtração \n Digite um numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            n2 = float.Parse(Console.ReadLine());
            resultado = n1 - n2;
            Console.WriteLine($"A Subtração de {n1} - {n2} = {resultado}");
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Você escolheu Multiplicação \n Digite um numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            n2 = float.Parse(Console.ReadLine());
            resultado = n1 * n2;
            Console.WriteLine($"A Multiplicação de {n1} * {n2} = {resultado}");
            break;
        case 4:
            Console.Clear();
            Console.WriteLine("Você escolheu Divisão \n Digite um numero:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            n2 = float.Parse(Console.ReadLine());
            resultado = n1 / n2;
            Console.WriteLine($"A Divisão de {n1} / {n2} = {resultado}");
            break;
        case 99:
            Console.Clear();
            Console.WriteLine("Você escolheu Sair, o programa será encerrado");
            Task.Delay(2000).Wait();
            break;
        default:
            Console.WriteLine("Opção Invalida, digite novamente ");
            Task.Delay(2000).Wait();
            Console.Clear();
            Console.WriteLine("Selecione tipo de operação:\n 1-Soma\n 2-Subtração\n 3-Multiplicação\n 4-Divisão \n 99 - SAIR");
            goto voltaAqui;

    }
}

