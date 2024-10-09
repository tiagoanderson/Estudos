namespace calculadora.Itens
{
    public abstract class Operation
    {
        public abstract float Execute(float n1, float n2);
        public abstract string GetSymbol();
    }

    public class Addition : Operation
    {
        public override float Execute(float n1, float n2) => n1 + n2;
        public override string GetSymbol() => "+";
    }

    public class Subtraction : Operation
    {
        public override float Execute(float n1, float n2) => n1 - n2;
        public override string GetSymbol() => "-";
    }

    public class Multiplication : Operation
    {
        public override float Execute(float n1, float n2) => n1 * n2;
        public override string GetSymbol() => "*";
    }

    public class Division : Operation
    {
        public override float Execute(float n1, float n2)
        {
            if (n2 == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            return n1 / n2;
        }

        public override string GetSymbol() => "/";
    }

    public class OperationHistory
    {
        private readonly List<string> _history;

        public OperationHistory()
        {
            _history = new List<string>();
        }

        public void AddEntry(float n1, float n2, Operation operation, float result)
        {
            string entry = $"{n1} {operation.GetSymbol()} {n2} = {result}";
            _history.Add(entry);
        }

        public void ShowHistory()
        {
            if (_history.Count == 0)
            {
                Console.WriteLine("Nenhuma operação foi realizada ainda.");
                return;
            }

            Console.WriteLine("Histórico de operações:");
            foreach (var entry in _history)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
