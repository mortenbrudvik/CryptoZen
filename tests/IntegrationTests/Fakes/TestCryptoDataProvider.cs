using System.IO;
using Infrastructure.DataProvider.CoinMarketCap;

namespace IntegrationTests.Fakes
{
    public class TestCryptoDataProvider : CoinMarketCapDataProvider
    {
        public override void Load()
        {
            var parser = new CoinMarketCapParser();
            var jsonData = File.ReadAllText(@"test-data\\market-data.json");
            var coins = parser.Parse(jsonData);
            foreach (var coin in coins)
                Coins.Add(coin);
        }
    }
}