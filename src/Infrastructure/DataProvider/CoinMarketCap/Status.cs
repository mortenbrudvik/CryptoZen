using System;
using System.Runtime.Serialization;

namespace Infrastructure.DataProvider.CoinMarketCap
{
    [DataContract(Name = "status")]
    public class Status
    {
        [DataMember(Name = "timestamp")]
        public DateTime Timestamp { get; set; }
        
        [DataMember(Name = "total_count")]
        public int Count { get; set; }
        
    }
}