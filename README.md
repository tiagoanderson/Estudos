# Projeto: Calculadora

## Descrição
Este é um projeto de uma calculadora simples, desenvolvido em C#. O objetivo é demonstrar a implementação de operações matemáticas básicas (soma, subtração, multiplicação e divisão) e aplicar conceitos de SOLID e Clean Code.

## Funcionalidades

Operações Básicas: Soma, Subtração, Multiplicação e Divisão.

Registro de Operações: Armazena o histórico de operações realizadas.

Exibição de Operações: Permite exibir todas as operações realizadas e a última operação.

## Como Executar o Projeto

### Passos para Executar

1. Clone este repositório:
   ```bash
   git clone https://github.com/tiagoanderson/Estudos.git
  
2. Navegue até a pasta do projeto:
   ```bash
   cd Calculadora

3.   Compile e execute o projeto:

Utilizando o Visual Studio, abra o arquivo .sln do projeto e pressione F5 para compilar e executar.

## Exemplo de Uso
Operação Básica:
<br>Soma

 ```csharp
var soma = new Soma();
double resultado = soma.Calcular(10, 5);
Console.WriteLine($"Resultado da soma: {resultado}"); // Saída: 15
 ```
<br>Subtração
```csharp
var subtracao = new Subtracao();
double resultado = subtracao.Calcular(10, 5);
Console.WriteLine($"Resultado da subtração: {resultado}"); // Saída: 5
 ```
<br>Multiplicação
```csharp
var multiplicacao = new Multiplicacao();
double resultado = multiplicacao.Calcular(10, 5);
Console.WriteLine($"Resultado da multiplicação: {resultado}"); // Saída: 50
 ```
<br>Divisão
```csharp
var divisao = new Divisao();
double resultado = divisao.Calcular(10, 5);
Console.WriteLine($"Resultado da divisão: {resultado}"); // Saída: 2
 ```

## Ferramentas Utilizadas
Visual Studio 2022

.NET 6.0

xUnit

Fine Code Coverage

## Instalação do Fine Code Coverage
Para instalar a extensão Fine Code Coverage no Visual Studio, siga estes passos:

Abra o Visual Studio.

Vá para Extensions > Manage Extensions.

Procure por Fine Code Coverage e instale a extensão.

Executar os Testes com Cobertura de Código





