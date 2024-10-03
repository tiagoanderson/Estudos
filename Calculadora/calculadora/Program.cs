using System;

float n1 = 0;
float n2 = 0;
float resultado = 0;
int seletor = 99;


while (seletor != 99)
    Console.WriteLine("+++++++++++++++Calculadora+++++++++++++++");
    Console.WriteLine("Selecione tipo de operação:\n 1-Soma\n 2-Subtração\n 3-Multiplicação\n 4-Divisão \n 99 - SAIR");
voltaAqui:
seletor = int.Parse(Console.ReadLine());
switch (seletor)
{
    case 1:
        Console.WriteLine("Você escolheu Soma: \n Digite um numero:");
        n1 = float.Parse(Console.ReadLine());
         Console.WriteLine("Digite outro numero:");
        n2 = float.Parse(Console.ReadLine());
        resultado = n1 + n2;
        Console.WriteLine($"A soma de {n1} + {n2} = {resultado}");
        break;
    case 2:
        Console.WriteLine("Você escolheu Subtração \n Digite um numero:");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero:");
        n2 = float.Parse(Console.ReadLine());
        resultado = n1 - n2;
        Console.WriteLine($"A Subtração de {n1} - {n2} = {resultado}");
        break;
    case 3:
        Console.WriteLine("Você escolheu Multiplicação \n Digite um numero:");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero:");
        n2 = float.Parse(Console.ReadLine());
        resultado = n1 * n2;
        Console.WriteLine($"A Multiplicação de {n1} * {n2} = {resultado}");
        break;
    case 4:
        Console.WriteLine("Você escolheu Divisão \n Digite um numero:");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro numero:");
        n2 = float.Parse(Console.ReadLine());
        resultado = n1 / n2;
        Console.WriteLine($"A Divisão de {n1} / {n2} = {resultado}");
        break;
    case 99:
        Console.WriteLine("Você escolheu Sair");
        break;
    default:
        Console.WriteLine("Opção Invalida, digite novamente ");
        goto voltaAqui;
       
}





//Console.WriteLine("Digite um numero");
//n1 = float.Parse(Console.ReadLine());

