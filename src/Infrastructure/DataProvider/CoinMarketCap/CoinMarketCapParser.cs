using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace Infrastructure.DataProvider.CoinMarketCap
{
    public class CoinMarketCapParser
    {
        public IEnumerable<CoinMarketCapData> Parse(string marketData)
        {
            using var doc = JsonDocument.Parse(marketData);
            var root = doc.RootElement;
            var coins = root.GetProperty("data").EnumerateArray();
                   
            var coinList = new List<CoinMarketCapData>();
            
            foreach (var coin in coins)
            {
                var value = coin.Get("quote")?.Get("USD")?.Get("price")?.GetDouble();
                coinList.Add(new CoinMarketCapData()
                {
                    Id = coin.GetProperty("id").ToString(),
                    Symbol = coin.GetProperty("symbol").ToString(),
                    Name = coin.GetProperty("name").ToString(),
                    Value = coin.Get("quote")?.Get("USD")?.Get("price")?.GetDouble() ?? 0.0
                });
            }
      
            return coinList;
        }
    }
    
    public static partial class JsonExtensions
    {
        public static JsonElement? Get(this JsonElement element, string name) => 
            element.ValueKind != JsonValueKind.Null && element.ValueKind != JsonValueKind.Undefined && element.TryGetProperty(name, out var value) 
                ? value : (JsonElement?)null;

        public static JsonElement? Get(this JsonElement element, int index)
        {
            if (element.ValueKind == JsonValueKind.Null || element.ValueKind == JsonValueKind.Undefined)
                return null;
            var value = element.EnumerateArray().ElementAtOrDefault(index);
            return value.ValueKind != JsonValueKind.Undefined ? value : (JsonElement?)null;
        }
    }
}