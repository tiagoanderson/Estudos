
using calculadora;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit;
namespace calculadora.Tests;



    public class TesteOperacoes 
{
  

    [Fact]
  public void TestExceptionDivisaoPorZero()
 
   {
        var div = new Divisao();
        double n1 = 10.0;
        double n2 = 0.0000000;
     

        Assert.Throws<DivideByZeroException>(()  => div.Calcular(n1,n2));
      
    }

    [Fact]
    public void TesteDivisao()

    {
        var div = new Divisao();
        double n1 = 10.00;
        double n2 = 2.00;
   
        double resultado = div.Calcular(n1, n2);
        Assert.Equal(5, resultado);
    }

    [Fact]
    public void TesteDivisaoNumerosNegativos()

    {
        var div = new Divisao();
        double n1 = -10.00;
        double n2 = 2.00;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(-5, resultado);
    }

    // Testes Operação Somar

    [Fact]
    public void TesteOperacaoSomarNumerosDouble()

    {
        var div = new Soma();
        double n1 = 10.00;
        double n2 = 2.00;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(12, resultado);
    }



    [Fact]
    public void TesteOperacaoSomarNumerosDoubleNegativos()

    {
        var div = new Soma();
        double n1 = -10.00;
        double n2 = -2.00;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(-12, resultado);
    }



    [Fact]
    public void TesteOperacaoSomarNumerosInterioNegativos()

    {
        var div = new Soma();
        double n1 = -10;
        double n2 = -2000;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(-2010, resultado);
    }

    // Teste operação Subtracao
    [Fact]
    public void TesteOperacaoSubtracaoNumerosDoubleNegativos()

    {
        var div = new Subtracao();
        double n1 = -10.00;
        double n2 = -2.00;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(-8, resultado);
    }



    [Fact]
    public void TesteOperacaoSubtracaoNumerosInterioNegativos()

    {
        var div = new Subtracao();
        double n1 = -2000;
        double n2 = -10;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(-1990, resultado);
    }

    [Fact]
    public void TesteOperacaoSubtrairNumerosDouble()

    {
        var div = new Subtracao();
        double n1 = 10.00;
        double n2 = 2.00;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(8, resultado);
    }

    // Teste operação Multiplicação
    [Fact]
    public void TesteOperacaoMultiplicacaoNumerosDoubleNegativos()

    {
        var div = new Multiplicacao();
        double n1 = -10.00;
        double n2 = -2.00;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(20, resultado);
    }



    [Fact]
    public void TesteOperacaoMultiplicacaoNumerosInterioNegativos()

    {
        var div = new Multiplicacao();
        double n1 = -2000;
        double n2 = -10;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(20000, resultado);
    }

    [Fact]
    public void TesteOperacaoMultiplicacaoNumerosDouble()

    {
        var div = new Multiplicacao();
        double n1 = 10.00;
        double n2 = 2.00;

        double resultado = div.Calcular(n1, n2);
        Assert.Equal(20, resultado);
    }




}


