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
        protected readonly List<CoinMarketCapData> _coins = new List<CoinMarketCapData>();
        public virtual void Load()
        {
        }
        
        public Option<CryptoCoin> Get(string symbol)
        {
            var coin =_coins.SingleOrDefault(x => x.Symbol == symbol);
            if (coin != null)
                return new CryptoCoin(coin.Name, 1.0);

            return None;
        }
    }
}