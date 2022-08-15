namespace Task12_WPF
{
    internal class Model
    {
        public double SymbolAction(double first, double second, char ch)
        {
            switch (ch)
            {
                case '+':
                    return first + second;
                case '-':
                    return first - second;
                case '*':
                    return first * second;
                case '/':
                    return first / second;
                default:
                    return -0;
            }
        }
    }
}
