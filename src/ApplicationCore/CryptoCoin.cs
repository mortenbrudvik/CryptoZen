namespace ApplicationCore
{
    public class CryptoCoin
    {
        public CryptoCoin(string name, double value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public double Value { get; }
    }
}