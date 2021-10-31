using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Infrastructure.DataProvider.CoinMarketCap
{

    [DataContract]
    public class MarketData
    {
        [DataMember(Name = "status")]
        public Status Status { get; set; }
        
        [DataMember(Name = "data")]
        public IEnumerable<CoinMarketCapData> CoinData { get; set; }
    }
}