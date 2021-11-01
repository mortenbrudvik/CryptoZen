using System.Runtime.Serialization;

namespace Infrastructure.DataProvider.CoinMarketCap
{
    public class CoinMarketCapData 
    {
        public string Id{ get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public double Value { get; set; }
    }
}