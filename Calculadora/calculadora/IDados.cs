namespace calculadora
{
    internal interface IDados
    {
        void GetExpressao();
        void GravarDados(double Numero1, double Numero2, double Resultado, int operacao);
    }
}