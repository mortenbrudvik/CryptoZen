namespace ApplicationCore
{
    public class CryptoCoin
    {
        public CryptoCoin(string symbol, string name, double value)
        {
            Symbol = symbol;
            Name = name;
            Value = value;
        }

        public string Symbol { get; }
        public string Name { get; }
        public double Value { get; }
    }
}