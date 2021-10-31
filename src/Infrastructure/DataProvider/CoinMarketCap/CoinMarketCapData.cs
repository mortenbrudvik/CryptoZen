using System.Runtime.Serialization;

namespace Infrastructure.DataProvider.CoinMarketCap
{
    [DataContract(Name = "data")]
    public class CoinMarketCapData 
    {
        [DataMember(Name = "id")]
        public string Id{ get; set; }
        
        [DataMember(Name = "name")]
        public string Name { get; set; }
        
        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }
    }
}