using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora.Tests
{
  public class TestesDados : DadosConcretos

    {
       
        [Fact]
        public void GravarDados_DeveAdicionarExpressaoParaSoma()
        {
            // Arrange
            var dados = new DadosConcretos();
            double numero1 = 10;
            double numero2 = 5;
            double resultado = 15;
            int operacao = 1; // Soma

            // Act
            dados.GravarDados(numero1, numero2, resultado, operacao);

            // Assert
            Assert.Single(dados.expressao); // Verifica se há apenas uma expressão gravada
            Assert.Contains("Operação: SOMA ( 10 + 5 = 15 )", dados.expressao[0]); // Verifica o conteúdo da expressão
        }

        [Fact]
        public void GravarDados_DeveAdicionarExpressaoParaDivisao()
        {
            var dados = new DadosConcretos();
            double numero1 = 10;
            double numero2 = 2;
            double resultado = 5;
            int operacao = 4; // Divisão

            dados.GravarDados(numero1, numero2, resultado, operacao);



            Assert.Single(dados.expressao);
            Assert.Contains("Operação: DIVISÃO ( 10 / 2 = 5 )", dados.expressao[0]);
        }

        [Fact]
        public void GravarDados_OperacaoInvalida_DeveNaoAdicionarExpressao()
        {
            var dados = new DadosConcretos();
            double numero1 = 10;
            double numero2 = 2;
            double resultado = 5;
            int operacao = 99; // Operação inválida

            dados.GravarDados(numero1, numero2, resultado, operacao);

            Assert.Empty(dados.expressao); // Não deve adicionar nenhuma expressão
        }

    

    }
}
