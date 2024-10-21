using calculadora;
using System.Diagnostics.CodeAnalysis;
internal class Program
{
    [ExcludeFromCodeCoverage]

    private static void Main(string[] args)
    {

        Console.WriteLine($" Olá {Environment.UserName}, Seja Bem Vindo(a)");
        Console.WriteLine('\n');
        Console.WriteLine("Pressione uma tecla para iniciar o Menu...");
        Console.ReadKey();
        NewMenu menu = new NewMenu();
        menu.ExibirMenu();
    }
}