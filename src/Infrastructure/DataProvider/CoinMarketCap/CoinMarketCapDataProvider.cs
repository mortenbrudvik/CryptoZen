using System.Collections.Generic;
using System.Linq;
using ApplicationCore;
using Infrastructure.Interfaces;
using LanguageExt;
using static LanguageExt.Prelude;

namespace Infrastructure.DataProvider.CoinMarketCap
{
    public class CoinMarketCapDataProvider : ICryptoDataProvider
    {
        protected readonly List<CoinMarketCapData> Coins = new();
        public virtual void Load()
        {
        }
        
        public Option<CryptoCoin> Get(string symbol)
        {
            var coin = Coins.SingleOrDefault(x => x.Symbol == symbol);
            if (coin != null)
                return new CryptoCoin(coin.Symbol, coin.Name, coin.Value);

            return None;
        }
    }
}