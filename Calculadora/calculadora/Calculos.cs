using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Calculos:Validacoes
    {
        private double _numero1 { get; set; }
        private double _numero2 { get; set; }
        public int MyProperty { get; set; }


        public double ResultadoSoma => Resultado();

        public string Expressao => $"{_numero1} + {_numero2} = {ResultadoSoma}";

       

      

        public Calculos() {      
        }

        public Calculos(double numero1, double numero2)
        {
            _numero1 = numero1; 
            _numero2 = numero2; 

        }

        public double Numero1
        {

            get { return _numero1; }
            set { _numero1 = value; }
        }


        public double Numero2
        {

            get { return _numero2; }
            set { _numero2 = value;
            }
        }




        private double Resultado()
        {
            return Numero1 + Numero2;
          
        }

        public void Exibir(int opcaoEscolhidaNumerica)
        {
            switch (opcaoEscolhidaNumerica)
            {
                case 1:
                    Console.WriteLine($"A soma de {Numero1} + {Numero2} = {ResultadoSoma} ");
                    Console.WriteLine('\n' + Expressao);
                    break;
                case 2:
                    Console.WriteLine($"A Subtração de {Numero1} - {Numero2} = {ResultadoSoma} ");
                    Console.WriteLine('\n' + Expressao);
                    break;
                case 3:
                    Console.WriteLine($"A Multiplicação de {Numero1} / {Numero2} = {ResultadoSoma} ");
                    Console.WriteLine('\n' + Expressao);
                    break;
                case 4:
                    Console.WriteLine($"A Divisão de {Numero1} / {Numero2} = {ResultadoSoma} ");
                    Console.WriteLine('\n' + Expressao);
                    break;
            }

        }


        public double Subtrair()    { return Numero1 - Numero2; }
        public double Multiplicar() { return Numero1 * Numero2; }
        public double Dividir()     { return Numero1 / Numero2; }

    }
}
