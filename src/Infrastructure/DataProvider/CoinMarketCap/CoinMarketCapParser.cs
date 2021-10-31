using Newtonsoft.Json;

namespace Infrastructure.DataProvider.CoinMarketCap
{
    public class CoinMarketCapParser
    {
        public MarketData Parse(string marketData)
        {
            var data = JsonConvert.DeserializeObject<MarketData>(marketData);
            return data;
        }
    }
}