namespace calculadora
{
    public class Soma : ICalcular
    {
        public Soma()
        {
        }

        public double Calcular(double Numero1, double Numero2)
        {
            return Numero1 + Numero2;
        }



    }
}
