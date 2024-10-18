
using calculadora;
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




}


